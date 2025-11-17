using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.KuchukIA.Sprint6.Task3.V24.Lib
{
    public class DataService : ISprint6Task3V24
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int j = 0; j < rows; j++)
            {
                if (matrix[1, j] % 2 == 0)
                {
                    matrix[1, j] = 0;
                }
            }
            return matrix;
        }
    }
}