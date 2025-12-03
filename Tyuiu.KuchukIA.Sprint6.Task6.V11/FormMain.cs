using System.IO;
using System.Windows.Forms;
using Tyuiu.KuchukIA.Sprint6.Task6.V11.Lib;
using System.Drawing;

namespace Tyuiu.KuchukIA.Sprint6.Task6.V11
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            textBoxInput_KIA.Multiline = true;
            textBoxInput_KIA.ScrollBars = ScrollBars.Both;
            textBoxInput_KIA.WordWrap = false;

            textBoxOutput_KIA.Multiline = true;
            textBoxOutput_KIA.ScrollBars = ScrollBars.Both;
            textBoxOutput_KIA.WordWrap = false;
        }

        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_KIA_Click(object sender, EventArgs e)
        {
            openFileDialogTask_KIA.ShowDialog();
            openFilePath = openFileDialogTask_KIA.FileName;



            string[] lines = File.ReadAllLines(openFilePath);
            textBoxInput_KIA.Text = string.Join(Environment.NewLine, lines);


            groupBoxInput_KIA.Text = "ֲגמה טח פאיכא: " + openFileDialogTask_KIA.FileName;

            buttonDone_KIA.Enabled = true;
        }

        private void buttonDone_KIA_Click(object sender, EventArgs e)
        {

            textBoxOutput_KIA.Text = ds.CollectTextFromFile(openFilePath);
        }

        private void buttonHelp_KIA_Click(object sender, EventArgs e)
        {
            FormAbout_KIA formAbout = new FormAbout_KIA();
            formAbout.ShowDialog();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxInput_KIA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxTask_KIA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}