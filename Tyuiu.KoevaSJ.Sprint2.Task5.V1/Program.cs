using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KoevaSJ.Sprint2.Task5.V1.Lib;

namespace Tyuiu.KoevaSJ.Sprint2.Task5.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнила: Коева С.Ю | АСОиУБ-23-1";
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                              *");
            Console.WriteLine("* Тема: Switch                                                                                           *");
            Console.WriteLine("* Задание #5                                                                                             *");
            Console.WriteLine("* Вариант #1                                                                                             *");
            Console.WriteLine("* Выполнила: Коева Софья Юрьевна    | АСОиУБ-23-1                                                        *");
            Console.WriteLine("**********************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                               *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат *");
            Console.WriteLine("* Условие: По данному номеру месяца, определите количество дней в этом месяце.                           *");

            Console.WriteLine("***********************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                        *");
            Console.WriteLine("***********************************************************************************************************");

            Console.WriteLine("Ведите номер месяца : ");
            int numMouth = Convert.ToInt32(Console.ReadLine());

            string res;

            if ((numMouth < 1) || (numMouth > 12))
            {
                res = "Введено неверное значение";
            }
            else
            {
                res = " В этом месяце " + ds.FindMonthDaysCount(numMouth);
            }
            Console.WriteLine("*************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                    *");
            Console.WriteLine("*************************************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();

        }
    }
}
