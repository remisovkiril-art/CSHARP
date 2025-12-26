using System;
using System.Data.Common;
namespace CSHARP
{
    internal class Program
    {
        static void Main()
        {
            // Задание 1
            Console.WriteLine("Задание 1: Квадрат с символами ");
            void DrawSquare(int sideLength, char symbol)
            {
                for (int i = 0; i < sideLength; i++)
                {
                    for (int j = 0; j < sideLength; j++)
                    {
                        Console.Write(symbol);
                    }
                    Console.WriteLine();
                }
            }
            Console.Write("Введите длину стороны квадрата: ");
            int sideLength = int.Parse(Console.ReadLine());
            Console.Write("Введите символ: ");
            char symbol = char.Parse(Console.ReadLine());
            DrawSquare(sideLength, symbol);
            Console.WriteLine();
            //Задание 2
            Console.WriteLine("Задание 2: Проверка палиндрома ");
            bool IsPalindrome(int number)
            {
                string text = number.ToString();
                string reversed = "";
                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversed += text[i];
                }
                return text == reversed;
            }
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            if (IsPalindrome(number))
                Console.WriteLine("Число является палиндромом");
            else
                Console.WriteLine("Число не является палиндромом");
            Console.WriteLine();
            // Задание 3
            Console.WriteLine("Задание 3: Фильтрация массива ");
            int[] FilterArray(int[] originalArray, int[] filterArray)
            {
                int count = 0;
                for (int i = 0; i < originalArray.Length; i++)
                {
                    bool found = false;

                    for (int j = 0; j < filterArray.Length; j++)
                    {
                        if (originalArray[i] == filterArray[j])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                        count++;
                }
                int[] resultArray = new int[count];
                int index = 0;
                for (int i = 0; i < originalArray.Length; i++)
                {
                    bool found = false;
                    for (int j = 0; j < filterArray.Length; j++)
                    {
                        if (originalArray[i] == filterArray[j])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        resultArray[index] = originalArray[i];
                        index++;
                    }
                }
                return resultArray;
            }
            int[] originalArray = { 1, 2, 6, -1, 88, 7, 6 };
            int[] filterArray = { 6, 88, 7 };
            int[] resultArray = FilterArray(originalArray, filterArray);
            Console.WriteLine("Результат:");
            Console.WriteLine(string.Join(" ", resultArray));
        }
    }
}
