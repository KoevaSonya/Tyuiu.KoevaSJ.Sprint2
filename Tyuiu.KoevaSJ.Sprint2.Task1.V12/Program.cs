using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint2.Task1.V12.Lib;

namespace Tyuiu.KoevaSJ.Sprint2.Task1.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Коева С.Ю | АСОиУБ-23-1";
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                     *");
            Console.WriteLine("* Тема: Операции сравнения                                                                      *");
            Console.WriteLine("* Задание #1                                                                                    *");
            Console.WriteLine("* Вариант #12                                                                                   *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевна    | АСОиУБ-23-1                                               *");
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                      *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=),                              *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^)                                                    *");
            Console.WriteLine("* которая вернет логическую последовательность(массив): (True, True, True, False, True, False)  *");

            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                              *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine("A = " + a);
            Console.WriteLine("B = " + b);
            Console.WriteLine("C = " + c);
            Console.WriteLine("D = " + b);


            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();


        }
    }
}
