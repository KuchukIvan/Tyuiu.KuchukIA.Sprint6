using Tyuiu.KuchukIA.Sprint6.Task6.V11.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();


            string testFile = "test.txt";
            File.WriteAllText(testFile, "Привет как дела\nПривет как дела\nПривет как дела\nПривет как дела\nПоследнее предпоследнее слово");

            string wait = "как как как как предпоследнее";
            string res = ds.CollectTextFromFile(testFile);

            Assert.AreEqual(wait, res);

            
            File.Delete(testFile);
        }
    }
}
