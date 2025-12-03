namespace Tyuiu.KuchukIA.Sprint6.Task5.V11
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
            panel1 = new Panel();
            buttonHelp_KIA = new Button();
            buttonOpenFile_KIA = new Button();
            buttonDone_KIA = new Button();
            groupBoxTask_KIA = new GroupBox();
            textBoxTask_KIA = new TextBox();
            panel2 = new Panel();
            groupBoxOutput_KIA = new GroupBox();
            dataGridViewNums_KIA = new DataGridView();
            panel3 = new Panel();
            chartDiag_KIA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panel1.SuspendLayout();
            groupBoxTask_KIA.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxOutput_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KIA).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_KIA).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp_KIA);
            panel1.Controls.Add(buttonOpenFile_KIA);
            panel1.Controls.Add(buttonDone_KIA);
            panel1.Controls.Add(groupBoxTask_KIA);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(965, 99);
            panel1.TabIndex = 0;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KIA.BackColor = SystemColors.InactiveCaption;
            buttonHelp_KIA.Location = new Point(859, 12);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(94, 66);
            buttonHelp_KIA.TabIndex = 3;
            buttonHelp_KIA.Text = "Справка";
            buttonHelp_KIA.UseVisualStyleBackColor = false;
            buttonHelp_KIA.Click += buttonHelp_KIA_Click;
            // 
            // buttonOpenFile_KIA
            // 
            buttonOpenFile_KIA.BackColor = Color.RoyalBlue;
            buttonOpenFile_KIA.Location = new Point(691, 14);
            buttonOpenFile_KIA.Name = "buttonOpenFile_KIA";
            buttonOpenFile_KIA.Size = new Size(94, 66);
            buttonOpenFile_KIA.TabIndex = 2;
            buttonOpenFile_KIA.Text = "Открыть файл";
            buttonOpenFile_KIA.UseVisualStyleBackColor = false;
            buttonOpenFile_KIA.Click += buttonOpenFile_KIA_Click;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.BackColor = Color.Green;
            buttonDone_KIA.Location = new Point(591, 14);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(94, 66);
            buttonDone_KIA.TabIndex = 1;
            buttonDone_KIA.Text = "Выполнить";
            buttonDone_KIA.UseVisualStyleBackColor = false;
            buttonDone_KIA.Click += buttonDone_KIA_Click;
            // 
            // groupBoxTask_KIA
            // 
            groupBoxTask_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTask_KIA.Location = new Point(3, 6);
            groupBoxTask_KIA.Name = "groupBoxTask_KIA";
            groupBoxTask_KIA.Size = new Size(582, 90);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие";
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.BackColor = SystemColors.Control;
            textBoxTask_KIA.BorderStyle = BorderStyle.None;
            textBoxTask_KIA.Location = new Point(6, 22);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(570, 65);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.Text = "Прочитать данные из файла InPutFileTask5V11.txt. Вывести в dataGridView. \r\nДан список из чисел. Вывести все числа, кратные 5. Построить диаграмму по этим значениям.";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxOutput_KIA);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 509);
            panel2.TabIndex = 1;
            // 
            // groupBoxOutput_KIA
            // 
            groupBoxOutput_KIA.Controls.Add(dataGridViewNums_KIA);
            groupBoxOutput_KIA.Dock = DockStyle.Left;
            groupBoxOutput_KIA.Location = new Point(0, 0);
            groupBoxOutput_KIA.Name = "groupBoxOutput_KIA";
            groupBoxOutput_KIA.Size = new Size(215, 509);
            groupBoxOutput_KIA.TabIndex = 0;
            groupBoxOutput_KIA.TabStop = false;
            groupBoxOutput_KIA.Text = "Вывод данных";
            // 
            // dataGridViewNums_KIA
            // 
            dataGridViewNums_KIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_KIA.ColumnHeadersVisible = false;
            dataGridViewNums_KIA.Dock = DockStyle.Left;
            dataGridViewNums_KIA.Location = new Point(3, 19);
            dataGridViewNums_KIA.Name = "dataGridViewNums_KIA";
            dataGridViewNums_KIA.ReadOnly = true;
            dataGridViewNums_KIA.RowHeadersVisible = false;
            dataGridViewNums_KIA.Size = new Size(209, 487);
            dataGridViewNums_KIA.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(chartDiag_KIA);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(218, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(747, 509);
            panel3.TabIndex = 2;
            // 
            // chartDiag_KIA
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_KIA.ChartAreas.Add(chartArea1);
            chartDiag_KIA.Dock = DockStyle.Fill;
            chartDiag_KIA.Location = new Point(0, 0);
            chartDiag_KIA.Name = "chartDiag_KIA";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PointWidth=0.3";
            series1.Name = "Series1";
            chartDiag_KIA.Series.Add(series1);
            chartDiag_KIA.Size = new Size(747, 509);
            chartDiag_KIA.TabIndex = 0;
            chartDiag_KIA.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(218, 99);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 509);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 608);
            Controls.Add(splitter1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(981, 647);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 11 | Кучук И.А.";
            Load += FormMain_Load;
            panel1.ResumeLayout(false);
            groupBoxTask_KIA.ResumeLayout(false);
            groupBoxTask_KIA.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxOutput_KIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_KIA).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_KIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBoxTask_KIA;
        private Panel panel2;
        private Panel panel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_KIA;
        private Splitter splitter1;
        private Button buttonHelp_KIA;
        private Button buttonOpenFile_KIA;
        private Button buttonDone_KIA;
        private TextBox textBoxTask_KIA;
        private GroupBox groupBoxOutput_KIA;
        private DataGridView dataGridViewNums_KIA;
    }
}
