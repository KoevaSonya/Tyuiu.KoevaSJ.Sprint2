using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint2;

//(True, True, True, False, True, False), при a = 152, b = 116, c = 887, d = 556

namespace Tyuiu.KoevaSJ.Sprint2.Task1.V12.Lib
{

    public class DataService : ISprint2Task1V12
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a < b) | (c > d);
            res[1] = (a > b) & (c - 500 < d);
            res[2] = (a > b) || (c - 2 < d);
            res[3] = (a > b) && (c < d);
            res[4] = !(!res[0]);
            res[5] = (a -50 < b) ^ (c - 500 < d);

            return res;
        }
    }
}
