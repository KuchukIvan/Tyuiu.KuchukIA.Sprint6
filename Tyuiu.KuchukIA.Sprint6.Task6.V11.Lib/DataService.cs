using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KuchukIA.Sprint6.Task6.V11.Lib
{
    public class DataService : ISprint6Task6V11
    {
        public string CollectTextFromFile(string path)
        {
            string resStr = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;

                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ');

                    if (words.Length >= 2)
                    {
                        string word = words[words.Length - 2];

                        resStr = resStr + word + " ";
                    }
                }
                return resStr.Trim();
            }
        }
    }
}