using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KuchukIA.Sprint6.Task1.V30.Lib
{
    public class DataService : ISprint6Task1V30
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                y = ((2 * x - 3) / (Math.Cos(x) - 2 * x)) + 5 * x - 6;
                res[count] = Math.Round(y, 2);
                count++;
            }

            return res;
        }
    }
}
