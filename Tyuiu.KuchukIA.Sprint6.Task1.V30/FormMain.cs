using Tyuiu.KuchukIA.Sprint6.Task1.V30.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task1.V30
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_KIA.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_KIA.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] res = ds.GetMassFunction(startStep, stopStep);

                textBoxResult_KIA.Text = "";

                textBoxResult_KIA.AppendText("+---------+-------------+" + Environment.NewLine);
                textBoxResult_KIA.AppendText("|    x    |     f(x)    |" + Environment.NewLine);
                textBoxResult_KIA.AppendText("+---------+-------------+" + Environment.NewLine);

                for (int i = 0; i <= res.Length - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}    |   {1,7:f2}   |", startStep, res[i]);
                    textBoxResult_KIA.AppendText(strLine + Environment.NewLine);
                    startStep++;

                }
                textBoxResult_KIA.AppendText("+---------+-------------+");
            }

            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ПИНб-25-1 Кучук Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

     


        }
    }






