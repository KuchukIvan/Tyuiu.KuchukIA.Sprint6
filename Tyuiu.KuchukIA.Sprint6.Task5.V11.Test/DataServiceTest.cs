using System.IO;
using Tyuiu.KuchukIA.Sprint6.Task5.V11.Lib;
namespace Tyuiu.KuchukIA.Sprint5.Task5.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckExistsFile()
        {
            string path = @"C:\DataSprint6\InPutDataFileTask5V11.txt";

            FileInfo fileInfo = new FileInfo(path);

            bool fileExists = fileInfo.Exists;

            bool wait = true;

            Assert.AreEqual(wait, fileExists);


        }
    }
}
