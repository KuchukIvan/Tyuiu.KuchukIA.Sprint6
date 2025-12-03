using System.IO;
using Tyuiu.KuchukIA.Sprint6.Task7.V7.Lib;

namespace Tyuiu.KuchukIA.Sprint6.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();

            string testFile = "test.csv";
            string csvContent = "2;4;6;8;10\n" +
                                "12;14;16;18;20\n" +
                                "22;24;26;28;30\n" +
                                "32;34;36;38;40\n" +
                                "1;3;5;7;9";

            File.WriteAllText(testFile, csvContent);

            int[,] wait = new int[5, 5]
            {
                {2, 4, 6, 8, 10},
                {12, 14, 16, 18, 20},
                {22, 24, 26, 28, 30},
                {32, 34, 36, 38, 40},
                {66, 66, 66, 66, 66}
            };

            int[,] res = ds.GetMatrix(testFile);

            CollectionAssert.AreEqual(wait, res);

            File.Delete(testFile);
        }
    }
}