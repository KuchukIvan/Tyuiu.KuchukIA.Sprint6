
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
            textBoxValueX_KIA = new TextBox();
            textBoxVarX_KIA = new TextBox();
            groupBoxResult_KIA = new GroupBox();
            textBoxResult_KIA = new TextBox();
            buttonHelp_KIA = new Button();
            buttonDone_KIA = new Button();
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
            groupBoxTask_KIA.Size = new Size(736, 275);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие";
            groupBoxTask_KIA.Enter += groupBox1_Enter;
            // 
            // pictureBoxFormula_KIA
            // 
            pictureBoxFormula_KIA.Image = Properties.Resources.Снимок_экрана_2025_11_15_004254;
            pictureBoxFormula_KIA.Location = new Point(595, 43);
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
            textBoxTask_KIA.Size = new Size(713, 223);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.Text = "Вычислить выражение по формуле";
            textBoxTask_KIA.TextChanged += textBox1_TextChanged;
            // 
            // groupBoxInput_KIA
            // 
            groupBoxInput_KIA.Controls.Add(textBoxValueX_KIA);
            groupBoxInput_KIA.Controls.Add(textBoxVarX_KIA);
            groupBoxInput_KIA.Location = new Point(30, 293);
            groupBoxInput_KIA.Name = "groupBoxInput_KIA";
            groupBoxInput_KIA.Size = new Size(488, 145);
            groupBoxInput_KIA.TabIndex = 1;
            groupBoxInput_KIA.TabStop = false;
            groupBoxInput_KIA.Text = "Ввод данных";
            groupBoxInput_KIA.Enter += groupBox2_Enter;
            // 
            // textBoxValueX_KIA
            // 
            textBoxValueX_KIA.BackColor = Color.WhiteSmoke;
            textBoxValueX_KIA.BorderStyle = BorderStyle.None;
            textBoxValueX_KIA.ForeColor = SystemColors.WindowText;
            textBoxValueX_KIA.Location = new Point(17, 80);
            textBoxValueX_KIA.Name = "textBoxValueX_KIA";
            textBoxValueX_KIA.Size = new Size(100, 16);
            textBoxValueX_KIA.TabIndex = 1;
            textBoxValueX_KIA.Text = "Переменная X:";
            textBoxValueX_KIA.BorderStyleChanged += textBox1_BorderStyleChanged;
            textBoxValueX_KIA.TextChanged += textBox1_TextChanged_1;
            // 
            // textBoxVarX_KIA
            // 
            textBoxVarX_KIA.Location = new Point(17, 96);
            textBoxVarX_KIA.Name = "textBoxVarX_KIA";
            textBoxVarX_KIA.Size = new Size(100, 23);
            textBoxVarX_KIA.TabIndex = 0;
            textBoxVarX_KIA.TextChanged += textBoxVarX_TextChanged;
            textBoxVarX_KIA.KeyPress += textBoxVarX_KeyPress;
            // 
            // groupBoxResult_KIA
            // 
            groupBoxResult_KIA.Controls.Add(textBoxResult_KIA);
            groupBoxResult_KIA.Location = new Point(524, 293);
            groupBoxResult_KIA.Name = "groupBoxResult_KIA";
            groupBoxResult_KIA.Size = new Size(232, 96);
            groupBoxResult_KIA.TabIndex = 2;
            groupBoxResult_KIA.TabStop = false;
            groupBoxResult_KIA.Text = "Вывод данных";
            // 
            // textBoxResult_KIA
            // 
            textBoxResult_KIA.Location = new Point(6, 52);
            textBoxResult_KIA.Multiline = true;
            textBoxResult_KIA.Name = "textBoxResult_KIA";
            textBoxResult_KIA.ReadOnly = true;
            textBoxResult_KIA.Size = new Size(220, 38);
            textBoxResult_KIA.TabIndex = 0;
            textBoxResult_KIA.TextChanged += textBoxResult_TextChanged;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.FlatStyle = FlatStyle.Flat;
            buttonHelp_KIA.Location = new Point(530, 395);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(48, 43);
            buttonHelp_KIA.TabIndex = 3;
            buttonHelp_KIA.Text = "?";
            buttonHelp_KIA.UseVisualStyleBackColor = true;
            buttonHelp_KIA.Click += buttonHelp_Click;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.Location = new Point(584, 395);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(172, 43);
            buttonDone_KIA.TabIndex = 4;
            buttonDone_KIA.Text = "Выполнить";
            buttonDone_KIA.UseVisualStyleBackColor = true;
            buttonDone_KIA.Click += buttonDone_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDone_KIA);
            Controls.Add(buttonHelp_KIA);
            Controls.Add(groupBoxResult_KIA);
            Controls.Add(groupBoxInput_KIA);
            Controls.Add(groupBoxTask_KIA);
            Name = "FormMain";
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
        private TextBox textBox2;
        private GroupBox groupBoxResult_KIA;
        private TextBox textBoxVarX_KIA;
        private TextBox textBoxResult_KIA;
        private Button buttonHelp_KIA;
        private Button buttonDone_KIA;
        private TextBox textBoxValueX_KIA;
    }
}
