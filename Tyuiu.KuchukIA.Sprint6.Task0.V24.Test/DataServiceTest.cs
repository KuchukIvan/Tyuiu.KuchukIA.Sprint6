using Tyuiu.KuchukIA.Sprint6.Task0.V24.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task0.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int x = 3;

            double res = ds.Calculate(x);

            double wait = 1024;

            Assert.AreEqual(wait, res);

        }
    }
}
