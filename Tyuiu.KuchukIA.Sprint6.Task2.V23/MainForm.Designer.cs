namespace Tyuiu.KuchukIA.Sprint6.Task2.V23
{
    partial class MainForm
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxTask_KIA = new GroupBox();
            textBoxTask_KIA = new TextBox();
            groupBoxOutput_KIA = new GroupBox();
            chartFunction_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction_KIA = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            Y = new DataGridViewTextBoxColumn();
            groupBoxInput_KIA = new GroupBox();
            textBoxForStopStep_KIA = new TextBox();
            textBoxForStartStep_KIA = new TextBox();
            textBoxStopStep_KIA = new TextBox();
            textBoxStartStep_KIA = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            buttonHelp_KIA = new Button();
            buttonDone_KIA = new Button();
            groupBoxTask_KIA.SuspendLayout();
            groupBoxOutput_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_KIA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KIA).BeginInit();
            groupBoxInput_KIA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KIA
            // 
            groupBoxTask_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTask_KIA.Location = new Point(12, 12);
            groupBoxTask_KIA.Name = "groupBoxTask_KIA";
            groupBoxTask_KIA.Size = new Size(520, 309);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие";
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.BackColor = SystemColors.Control;
            textBoxTask_KIA.BorderStyle = BorderStyle.None;
            textBoxTask_KIA.HideSelection = false;
            textBoxTask_KIA.Location = new Point(6, 22);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(508, 180);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.TabStop = false;
            textBoxTask_KIA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции.";
            textBoxTask_KIA.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxOutput_KIA
            // 
            groupBoxOutput_KIA.Controls.Add(chartFunction_KIA);
            groupBoxOutput_KIA.Controls.Add(dataGridViewFunction_KIA);
            groupBoxOutput_KIA.Location = new Point(538, 12);
            groupBoxOutput_KIA.Name = "groupBoxOutput_KIA";
            groupBoxOutput_KIA.Size = new Size(615, 387);
            groupBoxOutput_KIA.TabIndex = 1;
            groupBoxOutput_KIA.TabStop = false;
            groupBoxOutput_KIA.Text = "Вывод данных";
            // 
            // chartFunction_KIA
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_KIA.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction_KIA.Legends.Add(legend1);
            chartFunction_KIA.Location = new Point(143, 22);
            chartFunction_KIA.Name = "chartFunction_KIA";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_KIA.Series.Add(series1);
            chartFunction_KIA.Size = new Size(482, 359);
            chartFunction_KIA.TabIndex = 1;
            chartFunction_KIA.Text = "chart1";
            chartFunction_KIA.Click += chartFunction_KIA_Click;
            // 
            // dataGridViewFunction_KIA
            // 
            dataGridViewFunction_KIA.AllowUserToResizeColumns = false;
            dataGridViewFunction_KIA.AllowUserToResizeRows = false;
            dataGridViewFunction_KIA.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewFunction_KIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction_KIA.Columns.AddRange(new DataGridViewColumn[] { X, Y });
            dataGridViewFunction_KIA.Location = new Point(6, 22);
            dataGridViewFunction_KIA.Name = "dataGridViewFunction_KIA";
            dataGridViewFunction_KIA.ReadOnly = true;
            dataGridViewFunction_KIA.RowHeadersVisible = false;
            dataGridViewFunction_KIA.Size = new Size(133, 359);
            dataGridViewFunction_KIA.TabIndex = 0;
            dataGridViewFunction_KIA.TabStop = false;
            dataGridViewFunction_KIA.CellContentClick += dataGridView1_CellContentClick;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 60;
            // 
            // Y
            // 
            Y.HeaderText = "F(X)";
            Y.Name = "Y";
            Y.ReadOnly = true;
            Y.Width = 60;
            // 
            // groupBoxInput_KIA
            // 
            groupBoxInput_KIA.Controls.Add(textBoxForStopStep_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxForStartStep_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxStopStep_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxStartStep_KIA);
            groupBoxInput_KIA.Location = new Point(12, 327);
            groupBoxInput_KIA.Name = "groupBoxInput_KIA";
            groupBoxInput_KIA.Size = new Size(269, 72);
            groupBoxInput_KIA.TabIndex = 2;
            groupBoxInput_KIA.TabStop = false;
            groupBoxInput_KIA.Text = "Ввод данных";
            groupBoxInput_KIA.Enter += groupBoxInput_KIA_Enter;
            // 
            // textBoxForStopStep_KIA
            // 
            textBoxForStopStep_KIA.BackColor = SystemColors.Control;
            textBoxForStopStep_KIA.BorderStyle = BorderStyle.None;
            textBoxForStopStep_KIA.Location = new Point(137, 22);
            textBoxForStopStep_KIA.Name = "textBoxForStopStep_KIA";
            textBoxForStopStep_KIA.Size = new Size(100, 16);
            textBoxForStopStep_KIA.TabIndex = 6;
            textBoxForStopStep_KIA.Text = "Конец шага:";
            // 
            // textBoxForStartStep_KIA
            // 
            textBoxForStartStep_KIA.BackColor = SystemColors.Control;
            textBoxForStartStep_KIA.BorderStyle = BorderStyle.None;
            textBoxForStartStep_KIA.Location = new Point(6, 22);
            textBoxForStartStep_KIA.Name = "textBoxForStartStep_KIA";
            textBoxForStartStep_KIA.Size = new Size(100, 16);
            textBoxForStartStep_KIA.TabIndex = 5;
            textBoxForStartStep_KIA.Text = "Старт шага:";
            // 
            // textBoxStopStep_KIA
            // 
            textBoxStopStep_KIA.Location = new Point(137, 43);
            textBoxStopStep_KIA.Name = "textBoxStopStep_KIA";
            textBoxStopStep_KIA.Size = new Size(125, 23);
            textBoxStopStep_KIA.TabIndex = 1;
            textBoxStopStep_KIA.TextChanged += textBoxStopStep_KIA_TextChanged;
            // 
            // textBoxStartStep_KIA
            // 
            textBoxStartStep_KIA.Location = new Point(6, 43);
            textBoxStartStep_KIA.Name = "textBoxStartStep_KIA";
            textBoxStartStep_KIA.Size = new Size(125, 23);
            textBoxStartStep_KIA.TabIndex = 0;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KIA.Location = new Point(287, 338);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(100, 61);
            buttonHelp_KIA.TabIndex = 3;
            buttonHelp_KIA.Text = "Справка";
            buttonHelp_KIA.UseVisualStyleBackColor = false;
            buttonHelp_KIA.Click += buttonHelp_KIA_Click;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.BackColor = Color.Green;
            buttonDone_KIA.Location = new Point(393, 338);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(137, 61);
            buttonDone_KIA.TabIndex = 4;
            buttonDone_KIA.Text = "Выполнить";
            buttonDone_KIA.UseVisualStyleBackColor = false;
            buttonDone_KIA.Click += buttonDone_KIA_Click;
            buttonDone_KIA.MouseDown += buttonDone_KIA_MouseDown;
            buttonDone_KIA.MouseEnter += buttonDone_KIA_MouseEnter;
            buttonDone_KIA.MouseLeave += buttonDone_KIA_MouseLeave;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 405);
            Controls.Add(groupBoxInput_KIA);
            Controls.Add(groupBoxOutput_KIA);
            Controls.Add(buttonDone_KIA);
            Controls.Add(buttonHelp_KIA);
            Controls.Add(groupBoxTask_KIA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 23 | Кучук И.А.";
            Load += Form1_Load;
            groupBoxTask_KIA.ResumeLayout(false);
            groupBoxTask_KIA.PerformLayout();
            groupBoxOutput_KIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_KIA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction_KIA).EndInit();
            groupBoxInput_KIA.ResumeLayout(false);
            groupBoxInput_KIA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KIA;
        private GroupBox groupBoxOutput_KIA;
        private DataGridView dataGridViewFunction_KIA;
        private GroupBox groupBoxInput_KIA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KIA;
        private TextBox textBoxTask_KIA;
        private Button buttonDone_KIA;
        private Button buttonHelp_KIA;
        private TextBox textBoxStopStep_KIA;
        private TextBox textBoxStartStep_KIA;
        private TextBox textBoxForStopStep_KIA;
        private TextBox textBoxForStartStep_KIA;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn Y;
    }
}
