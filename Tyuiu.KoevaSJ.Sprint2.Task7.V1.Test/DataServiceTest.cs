using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint2.Task7.V1.Lib;

namespace Tyuiu.KoevaSJ.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.4;
            double y = 0.4;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}
