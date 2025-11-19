using System.Drawing.Drawing2D;
using Tyuiu.KuchukIA.Sprint6.Task3.V24.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task3.V24
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] {{-17, -6, 10, 5, 3},
                                   {-10, -14, 10, -7, -3},
                                   {-19, 9, 8, -17, -9},
                                   {-19, -5, -9, -18, 14},
                                   {17, 12, 11, 12, 2} };


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;


            dataGridViewMatrix_KIA.RowCount = rows;
            dataGridViewMatrix_KIA.ColumnCount = columns;


            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_KIA.Columns[i].Width = 25;
            }


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_KIA.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }

        }





        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            int[,] resultMatrix = ds.Calculate(matrix);


            dataGridViewResultMatrix_KIA.RowCount = resultMatrix.GetLength(0);
            dataGridViewResultMatrix_KIA.ColumnCount = resultMatrix.GetLength(1);

            for (int i = 0; i < resultMatrix.GetLength(1); i++)
            {
                dataGridViewResultMatrix_KIA.Columns[i].Width = 25;
            }


            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    dataGridViewResultMatrix_KIA.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ПИНб-25-1 Кучук Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
