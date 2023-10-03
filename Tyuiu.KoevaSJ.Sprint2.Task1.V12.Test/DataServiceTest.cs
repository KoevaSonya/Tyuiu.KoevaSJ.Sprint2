using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint2.Task1.V12.Lib;
namespace Tyuiu.KoevaSJ.Sprint2.Task1.V12.Test

// (True, True, True, False, True, False), при a = 152, b = 116, c = 887, d = 556
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()        
        {
            DataService ds = new DataService();
            int a = 152;
            int b = 116;
            int c = 887;
            int d = 556;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
