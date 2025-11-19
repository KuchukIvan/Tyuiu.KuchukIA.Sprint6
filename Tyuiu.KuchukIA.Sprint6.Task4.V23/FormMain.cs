using Tyuiu.KuchukIA.Sprint6.Task4.V23.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task4.V23
{
    public partial class FormMain : Form
    {
        public FormMain()
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


                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] res = ds.GetMassFunction(startStep, stopStep);



                this.chartFunction_KIA.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_KIA.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_KIA.Text = "";

                chartFunction_KIA.Series[0].Points.Clear();

                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_KIA.Series[0].Points.AddXY(startStep, res[i]);

                    textBoxResult_KIA.AppendText(res[i] + Environment.NewLine);

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
            MessageBox.Show("Таск 4 выполнил студент группы ПИНб-25-1 Кучук Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonSave_KIA_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4.txt";
                File.WriteAllText(path, textBoxResult_KIA.Text);

                DialogResult dialogResult = MessageBox.Show("Файл " + path + " сохранён успешно! \n Открыть его в блокноте?", "Сообщение", MessageBoxButtons.YesNo, MessageBoxIcon.Information);


                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
