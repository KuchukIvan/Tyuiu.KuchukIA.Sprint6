using Tyuiu.KuchukIA.Sprint6.Task5.V11.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task5.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();


        string path = @"C:\DataSprint6\InPutDataFileTask5V11.txt";

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            dataGridViewNums_KIA.ColumnCount = 2;
            dataGridViewNums_KIA.Columns[0].Width = 20;
            dataGridViewNums_KIA.Columns[1].Width = 50;

            this.chartDiag_KIA.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_KIA.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_KIA.Series[0].Points.Clear();

            double[] nums = ds.LoadFromDataFile(path);

            for (int i = 0; i < nums.Length; i++)
            {
                dataGridViewNums_KIA.Rows.Add(Convert.ToString(i), Convert.ToString(nums[i]));
                chartDiag_KIA.Series[0].Points.AddXY(i, nums[i]);
            }


        }

        private void buttonOpenFile_KIA_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ПИНб-25-1 Кучук Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
