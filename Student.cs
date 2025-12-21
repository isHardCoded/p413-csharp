using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double AverageGrade { get; set; }

        public Student(string name, int age, double averageGrade)
        {
            Name = name;
            Age = age;
            AverageGrade = averageGrade;
        }

        public string Format()
        {
            return $"{Name};{Age};{AverageGrade}";
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, AveragerGrade: {AverageGrade}";
        }
    }
    public class StudentManager 
    {
        List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            Console.WriteLine("Студент успешно добавлен");
        }

        public void PrintAllStudents()
        {
            if (!students.Any())
            {
                Console.WriteLine("Список пуст");
                return;
            }

            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public void SaveToFile(string path)
        {
            try
            {
                using(StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Student student in students)
                    {
                        writer.WriteLine(student.Format());
                    }

                    Console.WriteLine($"Данные успешны записаны в: {path}");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка при сохранении файла: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }
    
        public void LoadFromfile(string path)
        {
            try
            {
                students.Clear();
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(';');

                        if (parts.Length == 3)
                        {
                            string name = parts[0];
                            int age = int.Parse(parts[1]);
                            double grade = double.Parse(parts[2]);

                            students.Add(new Student(name, age, grade));
                        }
                    }
                }
                Console.WriteLine($"Данные загружены из файла: {path}");

            } catch(FileNotFoundException ex) 
            {
                Console.WriteLine($"Файл не найден: {ex.Message}");
            } catch(FormatException ex)
            {
                Console.WriteLine($"Ошибка формата данных в файле: {ex.Message}");
            } catch (IOException ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            } catch(Exception ex)
            {
                Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
            }
        }
    }
}
