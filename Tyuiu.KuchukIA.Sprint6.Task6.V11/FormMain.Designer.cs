namespace Tyuiu.KuchukIA.Sprint6.Task6.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp_KIA = new Button();
            buttonDone_KIA = new Button();
            buttonOpenFile_KIA = new Button();
            panel2 = new Panel();
            groupBoxTask_KIA = new GroupBox();
            textBoxTask_KIA = new TextBox();
            openFileDialogTask_KIA = new OpenFileDialog();
            toolTip_KIA = new ToolTip(components);
            splitContainer1 = new SplitContainer();
            groupBoxInput_KIA = new GroupBox();
            textBoxInput_KIA = new TextBox();
            groupBoxOutput_KIA = new GroupBox();
            textBoxOutput_KIA = new TextBox();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxTask_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBoxInput_KIA.SuspendLayout();
            groupBoxOutput_KIA.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_KIA);
            panel1.Controls.Add(buttonDone_KIA);
            panel1.Controls.Add(buttonOpenFile_KIA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(941, 80);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KIA.Location = new Point(847, 5);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(91, 64);
            buttonHelp_KIA.TabIndex = 2;
            buttonHelp_KIA.Text = "Справка";
            toolTip_KIA.SetToolTip(buttonHelp_KIA, "Сведение о программе");
            buttonHelp_KIA.UseVisualStyleBackColor = true;
            buttonHelp_KIA.Click += buttonHelp_KIA_Click;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.Location = new Point(100, 5);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(91, 64);
            buttonDone_KIA.TabIndex = 1;
            buttonDone_KIA.Text = "Выполнить";
            toolTip_KIA.SetToolTip(buttonDone_KIA, "Производит поиск предпоследнего слова в строке \r\n");
            buttonDone_KIA.UseVisualStyleBackColor = true;
            buttonDone_KIA.Click += buttonDone_KIA_Click;
            // 
            // buttonOpenFile_KIA
            // 
            buttonOpenFile_KIA.Location = new Point(3, 5);
            buttonOpenFile_KIA.Name = "buttonOpenFile_KIA";
            buttonOpenFile_KIA.Size = new Size(91, 64);
            buttonOpenFile_KIA.TabIndex = 0;
            buttonOpenFile_KIA.Text = "Открыть файл";
            toolTip_KIA.SetToolTip(buttonOpenFile_KIA, "Открыть файл\r\nВыберите нужный файл для обработки\r\n");
            buttonOpenFile_KIA.UseVisualStyleBackColor = true;
            buttonOpenFile_KIA.Click += buttonOpenFile_KIA_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxTask_KIA);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(941, 100);
            panel2.TabIndex = 1;
            // 
            // groupBoxTask_KIA
            // 
            groupBoxTask_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTask_KIA.Dock = DockStyle.Top;
            groupBoxTask_KIA.Location = new Point(0, 0);
            groupBoxTask_KIA.Name = "groupBoxTask_KIA";
            groupBoxTask_KIA.Size = new Size(941, 100);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие:";
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.BackColor = SystemColors.Control;
            textBoxTask_KIA.BorderStyle = BorderStyle.None;
            textBoxTask_KIA.Dock = DockStyle.Top;
            textBoxTask_KIA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_KIA.Location = new Point(3, 19);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(935, 75);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.Text = resources.GetString("textBoxTask_KIA.Text");
            textBoxTask_KIA.TextChanged += textBoxTask_KIA_TextChanged;
            // 
            // openFileDialogTask_KIA
            // 
            openFileDialogTask_KIA.FileName = "openFileDialog1";
            // 
            // toolTip_KIA
            // 
            toolTip_KIA.ToolTipIcon = ToolTipIcon.Info;
            toolTip_KIA.ToolTipTitle = "Подсказка";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 180);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBoxInput_KIA);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBoxOutput_KIA);
            splitContainer1.Panel2.Controls.Add(splitter1);
            splitContainer1.Size = new Size(941, 469);
            splitContainer1.SplitterDistance = 362;
            splitContainer1.TabIndex = 2;
            // 
            // groupBoxInput_KIA
            // 
            groupBoxInput_KIA.Controls.Add(textBoxInput_KIA);
            groupBoxInput_KIA.Dock = DockStyle.Fill;
            groupBoxInput_KIA.Location = new Point(0, 0);
            groupBoxInput_KIA.Name = "groupBoxInput_KIA";
            groupBoxInput_KIA.Size = new Size(362, 469);
            groupBoxInput_KIA.TabIndex = 0;
            groupBoxInput_KIA.TabStop = false;
            groupBoxInput_KIA.Text = "Ввод:";
            // 
            // textBoxInput_KIA
            // 
            textBoxInput_KIA.Dock = DockStyle.Fill;
            textBoxInput_KIA.Location = new Point(3, 19);
            textBoxInput_KIA.Multiline = true;
            textBoxInput_KIA.Name = "textBoxInput_KIA";
            textBoxInput_KIA.Size = new Size(356, 447);
            textBoxInput_KIA.TabIndex = 0;
            // 
            // groupBoxOutput_KIA
            // 
            groupBoxOutput_KIA.Controls.Add(textBoxOutput_KIA);
            groupBoxOutput_KIA.Dock = DockStyle.Fill;
            groupBoxOutput_KIA.Location = new Point(3, 0);
            groupBoxOutput_KIA.Name = "groupBoxOutput_KIA";
            groupBoxOutput_KIA.Size = new Size(572, 469);
            groupBoxOutput_KIA.TabIndex = 1;
            groupBoxOutput_KIA.TabStop = false;
            groupBoxOutput_KIA.Text = "Вывод:";
            // 
            // textBoxOutput_KIA
            // 
            textBoxOutput_KIA.Dock = DockStyle.Fill;
            textBoxOutput_KIA.Location = new Point(3, 19);
            textBoxOutput_KIA.Multiline = true;
            textBoxOutput_KIA.Name = "textBoxOutput_KIA";
            textBoxOutput_KIA.Size = new Size(566, 447);
            textBoxOutput_KIA.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(0, 0);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 469);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 649);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 11 | Кучук И.А.";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            groupBoxTask_KIA.ResumeLayout(false);
            groupBoxTask_KIA.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBoxInput_KIA.ResumeLayout(false);
            groupBoxInput_KIA.PerformLayout();
            groupBoxOutput_KIA.ResumeLayout(false);
            groupBoxOutput_KIA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonOpenFile_KIA;
        private Panel panel2;
        private Button buttonHelp_KIA;
        private Button buttonDone_KIA;
        private GroupBox groupBoxTask_KIA;
        private TextBox textBoxTask_KIA;
        private ToolTip toolTip_KIA;
        private OpenFileDialog openFileDialogTask_KIA;
        private SplitContainer splitContainer1;
        private GroupBox groupBoxInput_KIA;
        private TextBox textBoxInput_KIA;
        private GroupBox groupBoxOutput_KIA;
        private Splitter splitter1;
        private TextBox textBoxOutput_KIA;
    }
}
