namespace Tyuiu.KuchukIA.Sprint6.Task1.V30
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
            groupBoxTask_KIA = new GroupBox();
            textBoxTask_KIA = new TextBox();
            groupBoxOutput_KIA = new GroupBox();
            textBoxResult_KIA = new TextBox();
            groupBoxInput_KIA = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBoxStopStep_KIA = new TextBox();
            textBoxStartStep_KIA = new TextBox();
            buttonHelp_KIA = new Button();
            buttonDone_KIA = new Button();
            groupBoxTask_KIA.SuspendLayout();
            groupBoxOutput_KIA.SuspendLayout();
            groupBoxInput_KIA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KIA
            // 
            groupBoxTask_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTask_KIA.Location = new Point(12, 12);
            groupBoxTask_KIA.Name = "groupBoxTask_KIA";
            groupBoxTask_KIA.Size = new Size(537, 344);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие";
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.BackColor = SystemColors.Control;
            textBoxTask_KIA.Location = new Point(6, 22);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(525, 316);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы.";
            // 
            // groupBoxOutput_KIA
            // 
            groupBoxOutput_KIA.Controls.Add(textBoxResult_KIA);
            groupBoxOutput_KIA.Location = new Point(555, 12);
            groupBoxOutput_KIA.Name = "groupBoxOutput_KIA";
            groupBoxOutput_KIA.Size = new Size(233, 426);
            groupBoxOutput_KIA.TabIndex = 1;
            groupBoxOutput_KIA.TabStop = false;
            groupBoxOutput_KIA.Text = "Вывод данных";
            // 
            // textBoxResult_KIA
            // 
            textBoxResult_KIA.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult_KIA.Location = new Point(6, 23);
            textBoxResult_KIA.Multiline = true;
            textBoxResult_KIA.Name = "textBoxResult_KIA";
            textBoxResult_KIA.ReadOnly = true;
            textBoxResult_KIA.ScrollBars = ScrollBars.Vertical;
            textBoxResult_KIA.Size = new Size(221, 394);
            textBoxResult_KIA.TabIndex = 0;
            // 
            // groupBoxInput_KIA
            // 
            groupBoxInput_KIA.Controls.Add(textBox2);
            groupBoxInput_KIA.Controls.Add(textBox1);
            groupBoxInput_KIA.Controls.Add(textBoxStopStep_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxStartStep_KIA);
            groupBoxInput_KIA.Location = new Point(12, 362);
            groupBoxInput_KIA.Name = "groupBoxInput_KIA";
            groupBoxInput_KIA.Size = new Size(289, 76);
            groupBoxInput_KIA.TabIndex = 2;
            groupBoxInput_KIA.TabStop = false;
            groupBoxInput_KIA.Text = "Ввод данных";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(148, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 16);
            textBox2.TabIndex = 3;
            textBox2.Text = "Конец шага:";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(6, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 16);
            textBox1.TabIndex = 2;
            textBox1.Text = "Старт шага:";
            // 
            // textBoxStopStep_KIA
            // 
            textBoxStopStep_KIA.Location = new Point(148, 44);
            textBoxStopStep_KIA.Name = "textBoxStopStep_KIA";
            textBoxStopStep_KIA.Size = new Size(125, 23);
            textBoxStopStep_KIA.TabIndex = 1;
            // 
            // textBoxStartStep_KIA
            // 
            textBoxStartStep_KIA.Location = new Point(6, 44);
            textBoxStartStep_KIA.Name = "textBoxStartStep_KIA";
            textBoxStartStep_KIA.Size = new Size(125, 23);
            textBoxStartStep_KIA.TabIndex = 0;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.BackColor = SystemColors.MenuHighlight;
            buttonHelp_KIA.Location = new Point(307, 373);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(105, 65);
            buttonHelp_KIA.TabIndex = 3;
            buttonHelp_KIA.Text = "Справка";
            buttonHelp_KIA.UseVisualStyleBackColor = false;
            buttonHelp_KIA.Click += buttonHelp_KIA_Click;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.BackColor = Color.Green;
            buttonDone_KIA.Location = new Point(418, 373);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(131, 65);
            buttonDone_KIA.TabIndex = 4;
            buttonDone_KIA.Text = "Выполнить";
            buttonDone_KIA.UseVisualStyleBackColor = false;
            buttonDone_KIA.Click += buttonDone_KIA_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_KIA);
            Controls.Add(buttonHelp_KIA);
            Controls.Add(groupBoxInput_KIA);
            Controls.Add(groupBoxOutput_KIA);
            Controls.Add(groupBoxTask_KIA);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 30 | Кучук И.А.";
            groupBoxTask_KIA.ResumeLayout(false);
            groupBoxTask_KIA.PerformLayout();
            groupBoxOutput_KIA.ResumeLayout(false);
            groupBoxOutput_KIA.PerformLayout();
            groupBoxInput_KIA.ResumeLayout(false);
            groupBoxInput_KIA.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_KIA;
        private GroupBox groupBoxOutput_KIA;
        private TextBox textBoxTask_KIA;
        private GroupBox groupBoxInput_KIA;
        private Button buttonHelp_KIA;
        private Button buttonDone_KIA;
        private TextBox textBoxStopStep_KIA;
        private TextBox textBoxStartStep_KIA;
        private TextBox textBoxResult_KIA;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
