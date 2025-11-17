
namespace Tyuiu.KuchukIA.Sprint6.Task0.V24
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
            groupBoxTask_KIA = new GroupBox();
            pictureBoxFormula_KIA = new PictureBox();
            textBoxTask_KIA = new TextBox();
            groupBoxInput_KIA = new GroupBox();
            textBoxForVarX_KIA = new TextBox();
            textBoxVarX_KIA = new TextBox();
            groupBoxResult_KIA = new GroupBox();
            textBoxForResult_KIA = new TextBox();
            buttonDone_KIA = new Button();
            textBoxResult_KIA = new TextBox();
            buttonHelp_KIA = new Button();
            groupBoxTask_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KIA).BeginInit();
            groupBoxInput_KIA.SuspendLayout();
            groupBoxResult_KIA.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_KIA
            // 
            groupBoxTask_KIA.Controls.Add(pictureBoxFormula_KIA);
            groupBoxTask_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTask_KIA.Location = new Point(30, 12);
            groupBoxTask_KIA.Name = "groupBoxTask_KIA";
            groupBoxTask_KIA.Size = new Size(572, 275);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие";
            // 
            // pictureBoxFormula_KIA
            // 
            pictureBoxFormula_KIA.Image = Properties.Resources.Снимок_экрана_2025_11_15_004254;
            pictureBoxFormula_KIA.Location = new Point(413, 42);
            pictureBoxFormula_KIA.Name = "pictureBoxFormula_KIA";
            pictureBoxFormula_KIA.Size = new Size(135, 40);
            pictureBoxFormula_KIA.TabIndex = 1;
            pictureBoxFormula_KIA.TabStop = false;
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_KIA.Location = new Point(17, 32);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(542, 219);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.Text = "Вычислить выражение по формуле";
            textBoxTask_KIA.TextChanged += textBoxTask_KIA_TextChanged;
            // 
            // groupBoxInput_KIA
            // 
            groupBoxInput_KIA.Controls.Add(textBoxForVarX_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxVarX_KIA);
            groupBoxInput_KIA.Location = new Point(30, 293);
            groupBoxInput_KIA.Name = "groupBoxInput_KIA";
            groupBoxInput_KIA.Size = new Size(391, 145);
            groupBoxInput_KIA.TabIndex = 1;
            groupBoxInput_KIA.TabStop = false;
            groupBoxInput_KIA.Text = "Ввод данных";
            // 
            // textBoxForVarX_KIA
            // 
            textBoxForVarX_KIA.BackColor = SystemColors.Control;
            textBoxForVarX_KIA.BorderStyle = BorderStyle.None;
            textBoxForVarX_KIA.ForeColor = SystemColors.WindowText;
            textBoxForVarX_KIA.Location = new Point(17, 30);
            textBoxForVarX_KIA.Name = "textBoxForVarX_KIA";
            textBoxForVarX_KIA.Size = new Size(100, 16);
            textBoxForVarX_KIA.TabIndex = 1;
            textBoxForVarX_KIA.Text = "Переменная X:";
            // 
            // textBoxVarX_KIA
            // 
            textBoxVarX_KIA.Location = new Point(17, 52);
            textBoxVarX_KIA.Name = "textBoxVarX_KIA";
            textBoxVarX_KIA.Size = new Size(124, 23);
            textBoxVarX_KIA.TabIndex = 0;
            textBoxVarX_KIA.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxResult_KIA
            // 
            groupBoxResult_KIA.Controls.Add(textBoxForResult_KIA);
            groupBoxResult_KIA.Controls.Add(buttonDone_KIA);
            groupBoxResult_KIA.Controls.Add(textBoxResult_KIA);
            groupBoxResult_KIA.Controls.Add(buttonHelp_KIA);
            groupBoxResult_KIA.Location = new Point(427, 293);
            groupBoxResult_KIA.Name = "groupBoxResult_KIA";
            groupBoxResult_KIA.Size = new Size(175, 145);
            groupBoxResult_KIA.TabIndex = 2;
            groupBoxResult_KIA.TabStop = false;
            groupBoxResult_KIA.Text = "Вывод данных";
            // 
            // textBoxForResult_KIA
            // 
            textBoxForResult_KIA.BackColor = SystemColors.Control;
            textBoxForResult_KIA.BorderStyle = BorderStyle.None;
            textBoxForResult_KIA.ForeColor = SystemColors.WindowText;
            textBoxForResult_KIA.Location = new Point(6, 30);
            textBoxForResult_KIA.Name = "textBoxForResult_KIA";
            textBoxForResult_KIA.Size = new Size(100, 16);
            textBoxForResult_KIA.TabIndex = 5;
            textBoxForResult_KIA.Text = "Результат:";
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.Location = new Point(60, 96);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(109, 43);
            buttonDone_KIA.TabIndex = 4;
            buttonDone_KIA.Text = "Выполнить";
            buttonDone_KIA.UseVisualStyleBackColor = true;
            buttonDone_KIA.Click += buttonDone_Click;
            // 
            // textBoxResult_KIA
            // 
            textBoxResult_KIA.Location = new Point(6, 52);
            textBoxResult_KIA.Multiline = true;
            textBoxResult_KIA.Name = "textBoxResult_KIA";
            textBoxResult_KIA.ReadOnly = true;
            textBoxResult_KIA.Size = new Size(163, 38);
            textBoxResult_KIA.TabIndex = 0;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.FlatStyle = FlatStyle.Flat;
            buttonHelp_KIA.Location = new Point(6, 96);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(48, 43);
            buttonHelp_KIA.TabIndex = 3;
            buttonHelp_KIA.Text = "?";
            buttonHelp_KIA.UseVisualStyleBackColor = true;
            buttonHelp_KIA.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(612, 448);
            Controls.Add(groupBoxResult_KIA);
            Controls.Add(groupBoxInput_KIA);
            Controls.Add(groupBoxTask_KIA);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 24 | Кучук И.А. ";
            groupBoxTask_KIA.ResumeLayout(false);
            groupBoxTask_KIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_KIA).EndInit();
            groupBoxInput_KIA.ResumeLayout(false);
            groupBoxInput_KIA.PerformLayout();
            groupBoxResult_KIA.ResumeLayout(false);
            groupBoxResult_KIA.PerformLayout();
            ResumeLayout(false);
        }




        #endregion

        private GroupBox groupBoxTask_KIA;
        private PictureBox pictureBoxFormula_KIA;
        private TextBox textBoxTask_KIA;
        private GroupBox groupBoxInput_KIA;
        private TextBox textBox4;
        private TextBox textBox3;
        private GroupBox groupBoxResult_KIA;
        private TextBox textBoxVarX_KIA;
        private TextBox textBoxResult_KIA;
        private Button buttonHelp_KIA;
        private Button buttonDone_KIA;
        private TextBox textBoxForVarX_KIA;
        private TextBox textBoxForResult_KIA;
    }
}
