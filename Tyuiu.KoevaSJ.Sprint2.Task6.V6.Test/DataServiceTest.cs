using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KoevaSJ.Sprint2.Task6.V6.Lib;

namespace Tyuiu.KoevaSJ.Sprint2.Task6.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndValue()
        {
            DataService ds = new DataService();
            int m = 4;
            int k = 10;
            string res = ds.FindCardNameAndValue(m, k);
            string wait = "Десятка черви";
            Assert.AreEqual(wait, res);
        }
    }
}
