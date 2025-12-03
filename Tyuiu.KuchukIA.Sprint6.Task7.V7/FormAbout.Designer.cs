namespace Tyuiu.KuchukIA.Sprint6.Task7.V7
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelInfo_KIA = new Label();
            pictureBoxAvatar_KIA = new PictureBox();
            buttonOk_KIA = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KIA).BeginInit();
            SuspendLayout();
            // 
            // labelInfo_KIA
            // 
            labelInfo_KIA.AutoSize = true;
            labelInfo_KIA.Location = new Point(134, 9);
            labelInfo_KIA.Name = "labelInfo_KIA";
            labelInfo_KIA.Size = new Size(303, 135);
            labelInfo_KIA.TabIndex = 3;
            labelInfo_KIA.Text = resources.GetString("labelInfo_KIA.Text");
            // 
            // pictureBoxAvatar_KIA
            // 
            pictureBoxAvatar_KIA.Location = new Point(12, 9);
            pictureBoxAvatar_KIA.Name = "pictureBoxAvatar_KIA";
            pictureBoxAvatar_KIA.Size = new Size(111, 135);
            pictureBoxAvatar_KIA.TabIndex = 4;
            pictureBoxAvatar_KIA.TabStop = false;
            // 
            // buttonOk_KIA
            // 
            buttonOk_KIA.BackColor = SystemColors.ControlLightLight;
            buttonOk_KIA.Location = new Point(342, 161);
            buttonOk_KIA.Name = "buttonOk_KIA";
            buttonOk_KIA.Size = new Size(95, 27);
            buttonOk_KIA.TabIndex = 5;
            buttonOk_KIA.Text = "Ок";
            buttonOk_KIA.UseVisualStyleBackColor = false;
            buttonOk_KIA.Click += buttonOk_KIA_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(449, 200);
            Controls.Add(buttonOk_KIA);
            Controls.Add(pictureBoxAvatar_KIA);
            Controls.Add(labelInfo_KIA);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KIA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_KIA;
        private PictureBox pictureBoxAvatar_KIA;
        private Button buttonOk_KIA;
    }
}