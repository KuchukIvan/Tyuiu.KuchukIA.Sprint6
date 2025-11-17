using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KuchukIA.Sprint6.Task2.V23.Lib
{
    public class DataService : ISprint6Task2V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {

                if (2 * x - 2 == 0)
                {
                    res[count] = 0;
                }

                else
                {
                    y = (4 - 2 * x) + ((2 + Math.Cos(x)) / (2 * x - 2));
                    res[count] = Math.Round(y, 2);
                }
                count++;
            }

            return res;
        }
    }
}
