using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KuchukIA.Sprint6.Task7.V7.Lib
{
    public class DataService : ISprint6Task7V7
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] matrix = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    matrix[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            int xRow = 4;

            for (int c = 0; c < columns; c++)
            {
                if (matrix[xRow, c] % 2 != 0)
                {
                    matrix[xRow, c] = 66;
                }
            }
            return matrix;
        }
    }
}