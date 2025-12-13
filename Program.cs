using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    internal class Program
    {
        static int SumArray(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum;
        }

        static int[] SortArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }

        static int[] ReverseArray(int[] arr)
        {
            int[] arr2 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[arr.Length - 1 - i];
            }

            return arr2;
        }

        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            int[] values = new int[5];

            // Создать метод, который
            // принимает массив и возвращает сумму его элементов
            // Sum() - использовать нельзя!

            // Создать метод, который
            // переворачивает элементы массива

            // 1 2 3 4 5 -> 5 4 3 2 1

            // Создать метод, который сортирует массив по Bubble Sort
        }
    }
}
