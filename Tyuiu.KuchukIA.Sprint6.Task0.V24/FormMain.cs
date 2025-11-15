using Tyuiu.KuchukIA.Sprint6.Task0.V24.Lib;
namespace Tyuiu.KuchukIA.Sprint6.Task0.V24
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }


        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ПИНб-25-1 Кучук Иван Александрович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void buttonDone_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_KIA.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_KIA.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void textBoxVarX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

  
    }
}
