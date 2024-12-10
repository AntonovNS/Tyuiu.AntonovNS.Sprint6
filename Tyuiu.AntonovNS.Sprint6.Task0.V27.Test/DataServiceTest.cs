using System.IO;
using Tyuiu.AntonovNS.Sprint6.Task0.V27.Lib;
namespace Tyuiu.AntonovNS.Sprint6.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(7);
            double wait = 1.667;
            Assert.AreEqual(wait, res);
        }
    }
}