using Tyuiu.KuchukIA.Sprint6.Task2.V23.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task2.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;
            int len = stopValue - startValue + 1;

            double[] wait = new double[len];

            wait[0] = 13.81;
            wait[1] = 11.87;
            wait[2] = 9.87;
            wait[3] = 7.74;
            wait[4] = 5.36;
            wait[5] = 2.5;
            wait[6] = 0.0;
            wait[7] = 0.79;
            wait[8] = -1.75;
            wait[9] = -3.78;
            wait[10] = -5.71;

            double[] res = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}