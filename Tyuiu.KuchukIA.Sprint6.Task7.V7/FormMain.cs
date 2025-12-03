using System.Windows.Forms;
using Tyuiu.KuchukIA.Sprint6.Task7.V7.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task7.V7
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            openFileDialogTask_KIA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_KIA.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);

            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }


        private void buttonOpenFile_KIA_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_KIA.ShowDialog() == DialogResult.OK)
            {
                openFilePath = openFileDialogTask_KIA.FileName;

                int[,] arrayValues = LoadFromFileData(openFilePath);

                dataGridViewInPut_KIA.ColumnCount = columns;
                dataGridViewInPut_KIA.RowCount = rows;
                dataGridViewOutPut_KIA.ColumnCount = columns;
                dataGridViewOutPut_KIA.RowCount = rows;

                for (int i = 0; i < columns; i++)
                {
                    dataGridViewInPut_KIA.Columns[i].Width = 25;
                    dataGridViewOutPut_KIA.Columns[i].Width = 25;
                }

                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        dataGridViewInPut_KIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                    }
                }

                buttonDone_KIA.Enabled = true;
            }
        }

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPut_KIA.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSaveFile_KIA.Enabled = true;
        }

        private void buttonSaveFile_KIA_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_KIA.FileName = "OutPutFileTask7.csv";
            saveFileDialogMatrix_KIA.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_KIA.ShowDialog();

            string path = saveFileDialogMatrix_KIA.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPut_KIA.RowCount;
            int columns = dataGridViewOutPut_KIA.ColumnCount;

            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOutPut_KIA.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOutPut_KIA.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }



        private void ButtonHelp_KIA_Click(object sanded, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }



        private void FormMain_Load(object sanded, EventArgs e)
        {
            dataGridViewInPut_KIA.ColumnCount = 50;
            dataGridViewOutPut_KIA.ColumnCount = 50;

            dataGridViewInPut_KIA.RowCount = 50;
            dataGridViewOutPut_KIA.RowCount = 50;

            panelLeft_KIA.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPut_KIA.Columns[i].Width = 25;
                dataGridViewOutPut_KIA.Columns[i].Width = 25;
            }


        }




        private void buttonOpenFile_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KIA.ToolTipTitle = "Открыть файл";
            toolTipButton_KIA.SetToolTip(buttonOpenFile_KIA, "Нажмите для выбора CSV файла");
            toolTipButton_KIA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonDone_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KIA.ToolTipTitle = "Выполнить";
            toolTipButton_KIA.SetToolTip(buttonDone_KIA, "Запустить обработку матрицы");
            toolTipButton_KIA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonSaveFile_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KIA.ToolTipTitle = "Сохранить в файл";
            toolTipButton_KIA.SetToolTip(buttonSaveFile_KIA, "Сохранить результат в CSV файл");
            toolTipButton_KIA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void buttonHelp_KIA_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_KIA.ToolTipTitle = "Справка";
            toolTipButton_KIA.SetToolTip(buttonHelp_KIA, "Открыть информацию о программе");
            toolTipButton_KIA.ToolTipIcon = ToolTipIcon.Info;
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
 




