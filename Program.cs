using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1, str2;
            str1 = Console.ReadLine();
            str2 = Console.ReadLine();
            Console.WriteLine($"{str1}");
            Console.WriteLine($"{str2}");
            int iCompare = string.Compare(str1, str2);
            if (iCompare < 0)
            {
                Console.WriteLine(" str1 перед str2");
            }
             else if(iCompare>0)
            {
                Console.WriteLine(" str2 перед str1");
            }
            else
            {
                Console.WriteLine("одинаковые");
            }

            string str3 = null;
            string str4, str5;
            Console.WriteLine("Введите строку: ");
            str3 = Console.ReadLine();
            Console.WriteLine("Введите строку: ");
            str4 = Console.ReadLine();
            Console.WriteLine("Введите строку: ");
            str5 = Console.ReadLine();
            Console.WriteLine($"Интерполяция: {str3}");
            str4 = String.Copy(str3);
            Console.WriteLine($"Копирование: {str4}");
            int n = 0;
            bool flag = true;
            Console.WriteLine("Введите индекс символа, начиная с которого нужно вставить подстроку: ");
            while (flag)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < str4.Length)
                {
                    flag = false;
                }
                else Console.WriteLine("Неверный ввод! Повторите снова!");
            }

            str4 = str4.Substring(n);
            Console.WriteLine($"Полученная подстрока: {str4}");
            Console.WriteLine("Введите текст:");
            str5 = Console.ReadLine();
            string[] words = str5.Split(' ');
            Console.WriteLine("Слова, полученные после разбиения строки");
            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
            flag = true;

            Console.WriteLine("Введите индекс позиции, с которой будет вставляться подстрока: ");
            while (flag)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < str5.Length)
                {
                    flag = false;
                }
            }
            str5 = str5.Insert(n, str3);
            Console.WriteLine($"Третья строка после вставки в нее подстроки: {str5}");
            str5 = str5.Remove(n, str3.Length);
            Console.WriteLine($"Третья строка после удаления из нее подстроки: {str5}");
            str3 = String.Concat(str3, " and goodbye");
            Console.WriteLine($"Конкатенация с помощью метода String.Concat(): {str3}");


            //Массивы

            Console.WriteLine("Матрица:");
            int[,] Matrix = new int[4, 4];
            Random Elem = new Random();
            for (int I = 0; I < 4; I++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Matrix[I, j] = Elem.Next(1, 10);
                    Console.Write("{0}  ", Matrix[I, j]);
                }
                Console.WriteLine();
            }

            string[] arrOfStr = new string[] { "Hello", "Programming", "World", "String", "Parachute" };

            foreach (string el in arrOfStr)
            {
                Console.Write(el + ", ");
            }

            Console.WriteLine();
            Console.WriteLine($"Длина массива: {arrOfStr.Length}");
            flag = true;
            Console.WriteLine("Введите индекс строки в массиве, которую вы хотите заменить:");

            while (flag)
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n < arrOfStr.Length)
                {
                    flag = false;
                }
            }

            Console.WriteLine("Введите новую строку!");
            str3 = Console.ReadLine();

            for (int I = 0; I < arrOfStr.Length; I++)
            {
                if (I == n)
                {
                    arrOfStr[I] = str3;
                    break;
                }
            }

            Console.WriteLine("Измененный массив:");

            foreach (string el in arrOfStr)
            {
                Console.Write(el + ", ");
            }

            int[][] step = new int[3][];
            step[0] = new int[2];
            step[1] = new int[3];
            step[2] = new int[4];
            Console.WriteLine();
            Console.WriteLine("Заполнение ступенчатого массива:");

            for (int I = 0; I < step[0].Length; I++)
            {
                Console.WriteLine("Введите число: ");
                step[0][I] = Convert.ToInt32(Console.ReadLine());
            }
            for (int I = 0; I < step[1].Length; I++)
            {
                Console.WriteLine("Введите число: ");
                step[1][I] = Convert.ToInt32(Console.ReadLine());
            }
            for (int I = 0; I < step[2].Length; I++)
            {
                Console.WriteLine("Введите число: ");
                step[2][I] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Ступенчатый массив: ");
            for (int I = 0; I < step[0].Length; I++)
                Console.Write($"{step[0][I]} ");
            Console.WriteLine();
            for (int I = 0; I < step[1].Length; I++)
                Console.Write($"{step[1][I]} ");
            Console.WriteLine();
            for (int I = 0; I < step[2].Length; I++)
                Console.Write($"{step[2][I]} ");
            Console.WriteLine();

            var varString = "Greetings";
            Console.WriteLine($"Неявно типизированная переменная для хранения данных типа String: {varString}");
            var Arr = new[] { 2, 3, 4 };
            Console.WriteLine("Неявно типизированная переменная для хранения массива с данными типа int: {0}, {1}, {2}", Arr[0], Arr[1], Arr[2]);

            //Кортежи
          
            (int, string, char, string, ulong) T = (5, "Tuple", '1' , "Laboratory", 454252536);
            Console.WriteLine($"Элементы кортежа: {T.Item1}, {T.Item2}, {T.Item3}, {T.Item4}, {T.Item5}");
            (int a1, string a2, char a3, string a4, ulong a5) Tu = (5, "Tuple", '!', "Laboratory", 454252536);
            Console.WriteLine($"Элементы кортежа: { Tu.a1}, { Tu.a2}, { Tu.a3}, { Tu.a4}, { Tu.a5}");
            if (T == Tu)
            {
                Console.WriteLine("Кортежи равны!");
            }
            else Console.WriteLine("Кортежи не равны!");

            var (_, city, _, popularity) = (10, "city", 3, 1000);
            Console.WriteLine($"Город: {city}, население: {popularity}");

            int[] ToFun = new int[10];
            for (int I = 0; I < ToFun.Length; I++)
            {
                ToFun[I] = Elem.Next(1, 10);
                Console.Write($"{ToFun[I]} ");
            }
            Console.WriteLine();
            (int, int, int, char) Tup = MaxMinSumFirst(ref ToFun, "hello");
            (int, int, int, char) MaxMinSumFirst(ref int[] Arrr, string Str)
            {
                int Max, Min, Sum = 0;
                char ch1 = Str[0];
                Min = Max = Arrr[0];
                foreach (int m in Arrr)
                {
                    if (m > Max)
                        Max = m;
                    if (m < Min)
                        Min = m;
                    Sum += m;
                }
                (int, int, int, char) Tuple = (Max, Min, Sum, ch1);
                return Tuple;
            }
            Console.WriteLine($"Максимальный элемент массива: {Tup.Item1}.\n Минимальный элемент: {Tup.Item2}.\n Сумма элементов: {Tup.Item3}.\n Первая буква строки: {Tup.Item4}");
            
            void a()
            {
                checked
                {
                    int a1 = checked(2147483647);
                    a1++;
                }
            }
            void b1()
            {
                unchecked
                {
                    int a2 = 2147483647;
                    a2++;
                }
            }
            a();
            b1();
        }
    }
}

    
