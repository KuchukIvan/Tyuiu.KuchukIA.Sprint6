namespace Tyuiu.KuchukIA.Sprint6.Task4.V23
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            buttonHelp_KIA = new Button();
            buttonSave_KIA = new Button();
            groupBoxInput_KIA = new GroupBox();
            textBoxForStopStep_KIA = new TextBox();
            textBoxForStartStep_KIA = new TextBox();
            textBoxStopStep_KIA = new TextBox();
            textBoxStartStep_KIA = new TextBox();
            buttonDone_KIA = new Button();
            groupBoxTask_KIA = new GroupBox();
            textBoxTask_KIA = new TextBox();
            panel2 = new Panel();
            groupBoxOutput_KIA = new GroupBox();
            textBoxResult_KIA = new TextBox();
            panel3 = new Panel();
            chartFunction_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxInput_KIA.SuspendLayout();
            groupBoxTask_KIA.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutput_KIA.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KIA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_KIA);
            panel1.Controls.Add(buttonSave_KIA);
            panel1.Controls.Add(groupBoxInput_KIA);
            panel1.Controls.Add(buttonDone_KIA);
            panel1.Controls.Add(groupBoxTask_KIA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1154, 93);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KIA.BackColor = SystemColors.ActiveCaption;
            buttonHelp_KIA.Location = new Point(1043, 20);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(99, 60);
            buttonHelp_KIA.TabIndex = 4;
            buttonHelp_KIA.Text = "Справка";
            buttonHelp_KIA.UseVisualStyleBackColor = false;
            buttonHelp_KIA.Click += buttonHelp_KIA_Click;
            // 
            // buttonSave_KIA
            // 
            buttonSave_KIA.BackColor = Color.Green;
            buttonSave_KIA.Location = new Point(671, 19);
            buttonSave_KIA.Name = "buttonSave_KIA";
            buttonSave_KIA.Size = new Size(99, 62);
            buttonSave_KIA.TabIndex = 3;
            buttonSave_KIA.Text = "Сохранить";
            buttonSave_KIA.UseVisualStyleBackColor = false;
            buttonSave_KIA.Click += buttonSave_KIA_Click;
            // 
            // groupBoxInput_KIA
            // 
            groupBoxInput_KIA.Controls.Add(textBoxForStopStep_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxForStartStep_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxStopStep_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxStartStep_KIA);
            groupBoxInput_KIA.Location = new Point(385, 6);
            groupBoxInput_KIA.Name = "groupBoxInput_KIA";
            groupBoxInput_KIA.Size = new Size(280, 81);
            groupBoxInput_KIA.TabIndex = 2;
            groupBoxInput_KIA.TabStop = false;
            groupBoxInput_KIA.Text = "Ввод данных";
            // 
            // textBoxForStopStep_KIA
            // 
            textBoxForStopStep_KIA.BackColor = SystemColors.Control;
            textBoxForStopStep_KIA.BorderStyle = BorderStyle.None;
            textBoxForStopStep_KIA.Location = new Point(132, 22);
            textBoxForStopStep_KIA.Name = "textBoxForStopStep_KIA";
            textBoxForStopStep_KIA.Size = new Size(100, 16);
            textBoxForStopStep_KIA.TabIndex = 3;
            textBoxForStopStep_KIA.Text = "Конец шага:";
            // 
            // textBoxForStartStep_KIA
            // 
            textBoxForStartStep_KIA.BackColor = SystemColors.Control;
            textBoxForStartStep_KIA.BorderStyle = BorderStyle.None;
            textBoxForStartStep_KIA.Location = new Point(6, 22);
            textBoxForStartStep_KIA.Name = "textBoxForStartStep_KIA";
            textBoxForStartStep_KIA.Size = new Size(100, 16);
            textBoxForStartStep_KIA.TabIndex = 2;
            textBoxForStartStep_KIA.Text = "Старт шага:";
            // 
            // textBoxStopStep_KIA
            // 
            textBoxStopStep_KIA.Location = new Point(132, 44);
            textBoxStopStep_KIA.Name = "textBoxStopStep_KIA";
            textBoxStopStep_KIA.Size = new Size(120, 23);
            textBoxStopStep_KIA.TabIndex = 1;
            // 
            // textBoxStartStep_KIA
            // 
            textBoxStartStep_KIA.Location = new Point(6, 44);
            textBoxStartStep_KIA.Name = "textBoxStartStep_KIA";
            textBoxStartStep_KIA.Size = new Size(120, 23);
            textBoxStartStep_KIA.TabIndex = 0;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.BackColor = Color.RoyalBlue;
            buttonDone_KIA.Location = new Point(776, 19);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(99, 63);
            buttonDone_KIA.TabIndex = 1;
            buttonDone_KIA.Text = "Выполнить";
            buttonDone_KIA.UseVisualStyleBackColor = false;
            buttonDone_KIA.Click += buttonDone_KIA_Click;
            // 
            // groupBoxTask_KIA
            // 
            groupBoxTask_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTask_KIA.Location = new Point(6, 6);
            groupBoxTask_KIA.Name = "groupBoxTask_KIA";
            groupBoxTask_KIA.Size = new Size(373, 81);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие";
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.BackColor = SystemColors.Control;
            textBoxTask_KIA.BorderStyle = BorderStyle.None;
            textBoxTask_KIA.Location = new Point(6, 15);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(361, 61);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.TabStop = false;
            textBoxTask_KIA.Text = "Протабулировать функцию на заданном диапазоне от -5 до 5.\r\nРезультат вывести в textBox, построить график функции и сохранить файл OutPutFileTask.txt по нажатию кнопки.";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutput_KIA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 696);
            panel2.TabIndex = 1;
            // 
            // groupBoxOutput_KIA
            // 
            groupBoxOutput_KIA.Controls.Add(textBoxResult_KIA);
            groupBoxOutput_KIA.Dock = DockStyle.Fill;
            groupBoxOutput_KIA.Location = new Point(0, 0);
            groupBoxOutput_KIA.Name = "groupBoxOutput_KIA";
            groupBoxOutput_KIA.Size = new Size(235, 696);
            groupBoxOutput_KIA.TabIndex = 0;
            groupBoxOutput_KIA.TabStop = false;
            groupBoxOutput_KIA.Text = "Вывод данных";
            // 
            // textBoxResult_KIA
            // 
            textBoxResult_KIA.Dock = DockStyle.Fill;
            textBoxResult_KIA.Location = new Point(3, 19);
            textBoxResult_KIA.Multiline = true;
            textBoxResult_KIA.Name = "textBoxResult_KIA";
            textBoxResult_KIA.ReadOnly = true;
            textBoxResult_KIA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KIA.Size = new Size(229, 674);
            textBoxResult_KIA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartFunction_KIA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(235, 93);
            panel3.Name = "panel3";
            panel3.Size = new Size(919, 696);
            panel3.TabIndex = 1;
            // 
            // chartFunction_KIA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KIA.ChartAreas.Add(chartArea1);
            chartFunction_KIA.Dock = DockStyle.Fill;
            chartFunction_KIA.Location = new Point(0, 0);
            chartFunction_KIA.Name = "chartFunction_KIA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartFunction_KIA.Series.Add(series1);
            chartFunction_KIA.Size = new Size(919, 696);
            chartFunction_KIA.TabIndex = 0;
            chartFunction_KIA.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.RoyalBlue;
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartFunction_KIA.Titles.Add(title1);
            // 
            // splitter1
            // 
            splitter1.Location = new Point(235, 93);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 696);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 789);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1170, 828);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 23 | Кучук И.А.";
            panel1.ResumeLayout(false);
            groupBoxInput_KIA.ResumeLayout(false);
            groupBoxInput_KIA.PerformLayout();
            groupBoxTask_KIA.ResumeLayout(false);
            groupBoxTask_KIA.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutput_KIA.ResumeLayout(false);
            groupBoxOutput_KIA.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Splitter splitter1;
        private GroupBox groupBoxTask_KIA;
        private GroupBox groupBoxOutput_KIA;
        private TextBox textBoxResult_KIA;
        private Button buttonDone_KIA;
        private Button buttonHelp_KIA;
        private Button buttonSave_KIA;
        private GroupBox groupBoxInput_KIA;
        private TextBox textBoxTask_KIA;
        private TextBox textBoxForStopStep_KIA;
        private TextBox textBoxForStartStep_KIA;
        private TextBox textBoxStopStep_KIA;
        private TextBox textBoxStartStep_KIA;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KIA;
    }
}
