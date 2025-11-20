using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KuchukIA.Sprint6.Task5.V11.Lib
{
    public class DataService : ISprint6Task5V11
    {
        public int len = 0;

        public double[] LoadFromDataFile(string path)
        {
            string allText = File.ReadAllText(path);
            string[] strNums = allText.Split(' ');

            int arrayLength = strNums.Length;
            double[] nums = new double[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {

                string numberStr = strNums[i].Replace('.', ',');
                nums[i] = Convert.ToDouble(numberStr);
            }

            nums = nums.Where(val => val % 5 == 0).ToArray();
            len = nums.Length;
            return nums;
        }
    }
}
