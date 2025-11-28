namespace Tyuiu.KuchukIA.Sprint6.Task6.V11
{
    partial class FormAbout_KIA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_KIA));
            pictureBoxAvatar_KIA = new PictureBox();
            labelInfo_KIA = new Label();
            buttonOk_KIA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KIA).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KIA
            // 
            pictureBoxAvatar_KIA.Location = new Point(12, 12);
            pictureBoxAvatar_KIA.Name = "pictureBoxAvatar_KIA";
            pictureBoxAvatar_KIA.Size = new Size(111, 157);
            pictureBoxAvatar_KIA.TabIndex = 1;
            pictureBoxAvatar_KIA.TabStop = false;
            // 
            // labelInfo_KIA
            // 
            labelInfo_KIA.AutoSize = true;
            labelInfo_KIA.Location = new Point(129, 12);
            labelInfo_KIA.Name = "labelInfo_KIA";
            labelInfo_KIA.Size = new Size(303, 135);
            labelInfo_KIA.TabIndex = 2;
            labelInfo_KIA.Text = resources.GetString("labelInfo_KIA.Text");
            // 
            // buttonOk_KIA
            // 
            buttonOk_KIA.BackColor = SystemColors.Control;
            buttonOk_KIA.Location = new Point(357, 165);
            buttonOk_KIA.Name = "buttonOk_KIA";
            buttonOk_KIA.Size = new Size(75, 27);
            buttonOk_KIA.TabIndex = 3;
            buttonOk_KIA.Text = "Ок";
            buttonOk_KIA.UseVisualStyleBackColor = false;
            buttonOk_KIA.Click += buttonOk_KIA_Click;
            // 
            // FormAbout_KIA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(439, 200);
            Controls.Add(buttonOk_KIA);
            Controls.Add(labelInfo_KIA);
            Controls.Add(pictureBoxAvatar_KIA);
            Name = "FormAbout_KIA";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Сведение о программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxAvatar_KIA;
        private Label labelInfo_KIA;
        private Button buttonOk_KIA;
    }
}