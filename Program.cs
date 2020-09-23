using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //zad1 nom1

            bool b = true;
            int i = -10;
            uint ui = 10;
            byte by = 255;
            sbyte sb = -120;
            long li = -20000;
            ulong ul = 20000;
            short sh = -100;
            ushort ush = 100;
            decimal dec = 10.6m;
            double db = 2e10;
            float fl = 10.7f;
            char ch = '!';

            /*Console.WriteLine($"Логический тип данных bool: {b}");
              Console.WriteLine($"Логический тип данных int: {i}");
              Console.WriteLine($"Логический тип данных uint: {ui}");
              Console.WriteLine($"Логический тип данных long: {li}");
              Console.WriteLine($"Логический тип данных ulong: {ul}");
              Console.WriteLine($"Логический тип данных short: {sh}");
              Console.WriteLine($"Логический тип данных ushort: {ush}");
              Console.WriteLine($"Логический тип данных byte: {by}");
              Console.WriteLine($"Логический тип данных sbyte: {sb}");
              Console.WriteLine($"Логический тип данных decimal: {dec}");
              Console.WriteLine($"Логический тип данных double: {db}");
              Console.WriteLine($"Логический тип данных float: {fl}");
              Console.WriteLine($"Логический тип данных char: {ch}");


              Console.WriteLine($"введите int:");
              int a = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine($"введите bool:");
              bool b = Convert.ToBoolean(Console.ReadLine());
              Console.WriteLine($"введите byte:");
              byte c = Convert.ToByte(Console.ReadLine());
              Console.WriteLine($"введите sbyte:");
              sbyte d = Convert.ToSByte(Console.ReadLine());
              Console.WriteLine($"введите Char:");
              char ZAT = Convert.ToChar(Console.ReadLine());
              Console.WriteLine($"введите double:");
              double f = Convert.ToDouble(Console.ReadLine());
              Console.WriteLine($"введите decimal:");
              decimal h = Convert.ToDecimal(Console.ReadLine());
              Console.WriteLine($"введите float:");
              float r = Convert.ToSingle(Console.ReadLine());
              Console.WriteLine($"введите uint:");
              uint ui = Convert.ToUInt32(Console.ReadLine());
              Console.WriteLine($"введите long:");
              long lo = Convert.ToInt64(Console.ReadLine());
              Console.WriteLine($"введите ulong:");
              ulong ul =Convert.ToUInt64(Console.ReadLine()) ;
              Console.WriteLine($"введите short:");
              short sh = Convert.ToInt16(Console.ReadLine()); 
              Console.WriteLine($"введите ushort:");
              ushort us = Convert.ToUInt16(Console.ReadLine());

              Console.WriteLine($"{ZAT} '\u006A' ");
              Console.WriteLine($"{a}");
              Console.WriteLine($"{b}");
              Console.WriteLine($"{c}");
              Console.WriteLine($"{f}");
              Console.WriteLine($"{h}");
              Console.WriteLine($"{r}");
              Console.WriteLine($"{d}");
              Console.WriteLine($"{ui}");
              Console.WriteLine($"{lo}");
              Console.WriteLine($"{ul}");
              Console.WriteLine($"{sh}");
              Console.WriteLine($"{us}");*/


            //zad1 nom2
            // неявное
            /* li = i;
             i = sh;
             ui = ush;
             fl = by;
             db = sb;
             Console.WriteLine($"Неяное приведение int к long: {li}");
             Console.WriteLine($"Неяное приведение short к int: {i}");
             Console.WriteLine($"Неяное приведение ushort к uint: {ui}");
             Console.WriteLine($"Неяное приведение byte к float: {fl}");
             Console.WriteLine($"Неяное приведение sbyte к double: {db}");

             //явное
             ul = (ulong)ui;
             by = (byte)ch;
             db = (double)fl;
             dec = (decimal)ush;
             li = (long)sb;
             Console.WriteLine($"Явное приведение uint к ulong: {ul}");
             Console.WriteLine($"Явное приведение char к byte: {by}");
             Console.WriteLine($"Явное приведение float к double: {db}");
             Console.WriteLine($"Явное приведение ushort к decimal: {dec}");
             Console.WriteLine($"Явное приведение sbyte к long: {li}");*/

            //упаковка
            object obj = ui;
            Console.WriteLine($"{obj}");

            //распаковка
            ui = (uint)obj;
            Console.WriteLine($"{ui}");

            //неявно типизированная переменная
            var vr = 12.3m;
            Console.WriteLine($"{vr}");

            //null
            int? nul = null;
            Console.WriteLine($"{nul}");

            //Ошибка при присвоении переменной типа var значения другого типа
            var err = 23;
            // err = 2.54f; // - ошибка, не удается неявно преобразовать "float" в "int"


        }
    }
}
