namespace Tyuiu.KuchukIA.Sprint6.Task3.V24
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
            groupBoxTasl_KIA = new GroupBox();
            dataGridViewMatrix_KIA = new DataGridView();
            textBoxTask_KIA = new TextBox();
            groupBoxOutput_KIA = new GroupBox();
            textBoxResult_KIA = new TextBox();
            dataGridViewResultMatrix_KIA = new DataGridView();
            buttonHelp_KIA = new Button();
            buttonDone_KIA = new Button();
            groupBoxTasl_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KIA).BeginInit();
            groupBoxOutput_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix_KIA).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTasl_KIA
            // 
            groupBoxTasl_KIA.Controls.Add(dataGridViewResultMatrix_KIA);
            groupBoxTasl_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTasl_KIA.Location = new Point(12, 12);
            groupBoxTasl_KIA.Name = "groupBoxTasl_KIA";
            groupBoxTasl_KIA.Size = new Size(554, 322);
            groupBoxTasl_KIA.TabIndex = 0;
            groupBoxTasl_KIA.TabStop = false;
            groupBoxTasl_KIA.Text = "Условие";
            // 
            // dataGridViewMatrix_KIA
            // 
            dataGridViewMatrix_KIA.AllowUserToResizeColumns = false;
            dataGridViewMatrix_KIA.AllowUserToResizeRows = false;
            dataGridViewMatrix_KIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewMatrix_KIA.ColumnHeadersVisible = false;
            dataGridViewMatrix_KIA.Location = new Point(6, 48);
            dataGridViewMatrix_KIA.Name = "dataGridViewMatrix_KIA";
            dataGridViewMatrix_KIA.ReadOnly = true;
            dataGridViewMatrix_KIA.RowHeadersVisible = false;
            dataGridViewMatrix_KIA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewMatrix_KIA.Size = new Size(209, 205);
            dataGridViewMatrix_KIA.TabIndex = 1;
            dataGridViewMatrix_KIA.TabStop = false;
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.BackColor = SystemColors.Control;
            textBoxTask_KIA.BorderStyle = BorderStyle.None;
            textBoxTask_KIA.Location = new Point(6, 22);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(281, 351);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.TabStop = false;
            textBoxTask_KIA.Text = "Дан массив 5 на 5 элементов. Заменить четные значения во второй строке на 0.\r\n\r\n\r\n-17  -6  10   5   3\r\n\r\n -10 -14  10  -7  -3\r\n\r\n -19   9   8 -17  -9\r\n\r\n -19  -5  -9 -18  14\r\n\r\n  17  12  11  12   2";
            // 
            // groupBoxOutput_KIA
            // 
            groupBoxOutput_KIA.Controls.Add(dataGridViewMatrix_KIA);
            groupBoxOutput_KIA.Controls.Add(textBoxResult_KIA);
            groupBoxOutput_KIA.Location = new Point(572, 12);
            groupBoxOutput_KIA.Name = "groupBoxOutput_KIA";
            groupBoxOutput_KIA.Size = new Size(253, 266);
            groupBoxOutput_KIA.TabIndex = 1;
            groupBoxOutput_KIA.TabStop = false;
            groupBoxOutput_KIA.Text = "Вывод данных";
            // 
            // textBoxResult_KIA
            // 
            textBoxResult_KIA.BackColor = SystemColors.Control;
            textBoxResult_KIA.BorderStyle = BorderStyle.None;
            textBoxResult_KIA.Location = new Point(6, 26);
            textBoxResult_KIA.Name = "textBoxResult_KIA";
            textBoxResult_KIA.Size = new Size(100, 16);
            textBoxResult_KIA.TabIndex = 3;
            textBoxResult_KIA.TabStop = false;
            textBoxResult_KIA.Text = "Результат:";
            // 
            // dataGridViewResultMatrix_KIA
            // 
            dataGridViewResultMatrix_KIA.AllowUserToResizeColumns = false;
            dataGridViewResultMatrix_KIA.AllowUserToResizeRows = false;
            dataGridViewResultMatrix_KIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewResultMatrix_KIA.ColumnHeadersVisible = false;
            dataGridViewResultMatrix_KIA.Location = new Point(293, 48);
            dataGridViewResultMatrix_KIA.Name = "dataGridViewResultMatrix_KIA";
            dataGridViewResultMatrix_KIA.ReadOnly = true;
            dataGridViewResultMatrix_KIA.RowHeadersVisible = false;
            dataGridViewResultMatrix_KIA.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewResultMatrix_KIA.Size = new Size(209, 205);
            dataGridViewResultMatrix_KIA.TabIndex = 2;
            dataGridViewResultMatrix_KIA.TabStop = false;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.Location = new Point(572, 284);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(96, 50);
            buttonHelp_KIA.TabIndex = 2;
            buttonHelp_KIA.Text = "Справка";
            buttonHelp_KIA.UseVisualStyleBackColor = true;
            buttonHelp_KIA.Click += buttonHelp_KIA_Click;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.Location = new Point(674, 284);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(151, 50);
            buttonDone_KIA.TabIndex = 3;
            buttonDone_KIA.Text = "Выполнить";
            buttonDone_KIA.UseVisualStyleBackColor = true;
            buttonDone_KIA.Click += buttonDone_KIA_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 341);
            Controls.Add(buttonDone_KIA);
            Controls.Add(buttonHelp_KIA);
            Controls.Add(groupBoxOutput_KIA);
            Controls.Add(groupBoxTasl_KIA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 24 | Кучук И.А.";
            Load += FormMain_Load;
            groupBoxTasl_KIA.ResumeLayout(false);
            groupBoxTasl_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_KIA).EndInit();
            groupBoxOutput_KIA.ResumeLayout(false);
            groupBoxOutput_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultMatrix_KIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTasl_KIA;
        private DataGridView dataGridViewMatrix_KIA;
        private TextBox textBoxTask_KIA;
        private GroupBox groupBoxOutput_KIA;
        private TextBox textBoxResult_KIA;
        private DataGridView dataGridViewResultMatrix_KIA;
        private Button buttonHelp_KIA;
        private Button buttonDone_KIA;
    }
}
