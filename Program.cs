using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{ 
    internal class Program
    {
        private static StudentManager manager = new StudentManager();
        private const string FILE_PATH = @"C:\Users\User\Desktop\data.txt";
        
        static void ShowMenu()
        {
            Console.WriteLine("1 – Добавить студента");
            Console.WriteLine("2 – Показать всех студентов");
            Console.WriteLine("3 – Сохранить в файл");
            Console.WriteLine("4 – Загрузить из файла");
            Console.WriteLine("0 – Выход");

            Console.Write("Выберите действие: ");
        }

        static void AddStudent()
        {
            try
            {
                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                Console.Write("Возраст: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Средний балл: ");
                double grade = double.Parse(Console.ReadLine());

                Student student = new Student(name, age, grade);
                manager.AddStudent(student);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Возраст и балл должны быть числом");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }
        static void Main(string[] args)
        {
            while(true)
            {
                ShowMenu();

                try
                {
                    int input = int.Parse(Console.ReadLine());

                    switch(input)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            manager.PrintAllStudents();
                            break;
                        case 3:
                            manager.SaveToFile(FILE_PATH);
                            break;
                        case 4:
                            manager.LoadFromfile(FILE_PATH);
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Неверный выбор");
                            break;
                    }
                } catch(FormatException ex)
                {
                    Console.WriteLine("Введите число");
                } catch(Exception ex)
                {
                    Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                }
            }
        }
    }
}
