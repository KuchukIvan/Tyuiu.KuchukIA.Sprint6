using Tyuiu.KuchukIA.Sprint6.Task2.V23.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task2.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxStopStep_KIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            try
            {


                int startStep = Convert.ToInt32(textBoxStartStep_KIA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KIA.Text);


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] res = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_KIA.Titles.Add("График функции");

                this.chartFunction_KIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KIA.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction_KIA.Rows.Add(Convert.ToString(startStep), Convert.ToString(res[i]));

                    this.chartFunction_KIA.Series[0].Points.AddXY(startStep, res[i]);

                    startStep++;
                }
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПИНб-25-1 Кучук Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBoxInput_KIA_Enter(object sender, EventArgs e)
        {

        }

        private void chartFunction_KIA_Click(object sender, EventArgs e)
        {

        }



        private void buttonDone_KIA_MouseEnter(object sender, EventArgs e)
        {

            buttonDone_KIA.BackColor = Color.Red;

        }

        private void buttonDone_KIA_MouseLeave(object sender, EventArgs e)
        {

            buttonDone_KIA.BackColor = Color.Green;

        }


        private void buttonDone_KIA_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_KIA.BackColor = Color.Blue;

        }
    }
}

