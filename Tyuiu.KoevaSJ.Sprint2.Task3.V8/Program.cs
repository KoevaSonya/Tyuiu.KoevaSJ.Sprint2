using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint2.Task3.V8.Lib;

namespace Tyuiu.KoevaSJ.Sprint2.Task3.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Коева С.Ю | АСОиУБ-23-1";
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: вложенныq оператор if-else                                                                       *");
            Console.WriteLine("* Задание #3                                                                                             *");
            Console.WriteLine("* Вариант #8                                                                                             *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевна    | АСОиУБ-23-1                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет требуемое значение функции Y с использованием  if-else           *");
            Console.WriteLine("* где пользователь вводит значение переменной X с клавиатуры.                                            *");

            Console.WriteLine("***********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                        *");
            Console.WriteLine("***********************************************************************************************************");

            Console.WriteLine("Введите значение переменной Х:");
            double x = Convert.ToInt32(Console.ReadLine());
            double res = ds.Calculate(x);

            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine("Значение функции = " + res);

            Console.ReadKey();


        }
    }
}
