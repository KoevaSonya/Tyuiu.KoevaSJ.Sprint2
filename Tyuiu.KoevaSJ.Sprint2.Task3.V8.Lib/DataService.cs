using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KoevaSJ.Sprint2.Task3.V8.Lib
{
    public class DataService : ISprint2Task3V8
    {
        public double Calculate(double x)
        {
            double y = 0;

            if (x > 0)
            {
                y = Math.Round((Math.Sin(x) + Math.Cos(x)) / (Math.Cos(x) - Math.Sin(x)),3);
            }
            else
            {
                if (x==0)
                {
                    y = Math.Round(((x * x) - Math.Pow(Math.Cos(x), 2) + 10) / ((x * x) - Math.Pow(Math.Sin(x), 2) + 12), 3);
                }
                else
                {
                    if ((x > -12) && (x < 0))
                    {
                        y = Math.Round(Math.Pow(1 + (3 / (x*x)),x), 3);
                    }
                    else
                    {
                        if (x < -12)
                        {
                            y = Math.Round(x + 10 * x - (5 / x), 3);
                        }
                    }
                }
            }

            return y;
        }
    }
}
