namespace Tyuiu.KuchukIA.Sprint6.Task7.V7
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
            panelTop_KIA = new Panel();
            buttonHelp_KIA = new Button();
            buttonDone_KIA = new Button();
            buttonOpenFile_KIA = new Button();
            buttonSaveFile_KIA = new Button();
            panelCenter_KIA = new Panel();
            groupBoxTask_KIA = new GroupBox();
            textBoxTask_KIA = new TextBox();
            panelLeft_KIA = new Panel();
            groupBoxInPut_KIA = new GroupBox();
            dataGridViewInPut_KIA = new DataGridView();
            splitterPanels_KIA = new Splitter();
            panelRight_KIA = new Panel();
            groupBoxOutPut_KIA = new GroupBox();
            dataGridViewOutPut_KIA = new DataGridView();
            openFileDialogTask_KIA = new OpenFileDialog();
            toolTipButton_KIA = new ToolTip(components);
            saveFileDialogMatrix_KIA = new SaveFileDialog();
            panelTop_KIA.SuspendLayout();
            panelCenter_KIA.SuspendLayout();
            groupBoxTask_KIA.SuspendLayout();
            panelLeft_KIA.SuspendLayout();
            groupBoxInPut_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_KIA).BeginInit();
            panelRight_KIA.SuspendLayout();
            groupBoxOutPut_KIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KIA).BeginInit();
            SuspendLayout();
            // 
            // panelTop_KIA
            // 
            panelTop_KIA.Controls.Add(buttonHelp_KIA);
            panelTop_KIA.Controls.Add(buttonDone_KIA);
            panelTop_KIA.Controls.Add(buttonOpenFile_KIA);
            panelTop_KIA.Controls.Add(buttonSaveFile_KIA);
            panelTop_KIA.Dock = DockStyle.Top;
            panelTop_KIA.Location = new Point(0, 0);
            panelTop_KIA.Name = "panelTop_KIA";
            panelTop_KIA.Size = new Size(1079, 80);
            panelTop_KIA.TabIndex = 0;
            // 
            // buttonHelp_KIA
            // 
            buttonHelp_KIA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_KIA.FlatStyle = FlatStyle.Flat;
            buttonHelp_KIA.Image = (Image)resources.GetObject("buttonHelp_KIA.Image");
            buttonHelp_KIA.Location = new Point(985, 5);
            buttonHelp_KIA.Name = "buttonHelp_KIA";
            buttonHelp_KIA.Size = new Size(91, 69);
            buttonHelp_KIA.TabIndex = 5;
            buttonHelp_KIA.UseVisualStyleBackColor = true;
            buttonHelp_KIA.Click += ButtonHelp_KIA_Click;
            buttonHelp_KIA.MouseEnter += buttonHelp_KIA_MouseEnter;
            // 
            // buttonDone_KIA
            // 
            buttonDone_KIA.Enabled = false;
            buttonDone_KIA.FlatStyle = FlatStyle.Flat;
            buttonDone_KIA.Image = (Image)resources.GetObject("buttonDone_KIA.Image");
            buttonDone_KIA.Location = new Point(100, 5);
            buttonDone_KIA.Name = "buttonDone_KIA";
            buttonDone_KIA.Size = new Size(91, 69);
            buttonDone_KIA.TabIndex = 4;
            buttonDone_KIA.UseVisualStyleBackColor = true;
            buttonDone_KIA.Click += buttonDone_KIA_Click;
            buttonDone_KIA.MouseEnter += buttonDone_KIA_MouseEnter;
            // 
            // buttonOpenFile_KIA
            // 
            buttonOpenFile_KIA.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_KIA.Image = (Image)resources.GetObject("buttonOpenFile_KIA.Image");
            buttonOpenFile_KIA.Location = new Point(3, 5);
            buttonOpenFile_KIA.Name = "buttonOpenFile_KIA";
            buttonOpenFile_KIA.Size = new Size(91, 69);
            buttonOpenFile_KIA.TabIndex = 3;
            buttonOpenFile_KIA.UseVisualStyleBackColor = true;
            buttonOpenFile_KIA.Click += buttonOpenFile_KIA_Click;
            buttonOpenFile_KIA.MouseEnter += buttonOpenFile_KIA_MouseEnter;
            // 
            // buttonSaveFile_KIA
            // 
            buttonSaveFile_KIA.Enabled = false;
            buttonSaveFile_KIA.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_KIA.Image = (Image)resources.GetObject("buttonSaveFile_KIA.Image");
            buttonSaveFile_KIA.Location = new Point(197, 5);
            buttonSaveFile_KIA.Name = "buttonSaveFile_KIA";
            buttonSaveFile_KIA.Size = new Size(91, 69);
            buttonSaveFile_KIA.TabIndex = 2;
            buttonSaveFile_KIA.UseVisualStyleBackColor = true;
            buttonSaveFile_KIA.Click += buttonSaveFile_KIA_Click;
            buttonSaveFile_KIA.MouseEnter += buttonSaveFile_KIA_MouseEnter;
            // 
            // panelCenter_KIA
            // 
            panelCenter_KIA.Controls.Add(groupBoxTask_KIA);
            panelCenter_KIA.Dock = DockStyle.Top;
            panelCenter_KIA.Location = new Point(0, 80);
            panelCenter_KIA.Name = "panelCenter_KIA";
            panelCenter_KIA.Size = new Size(1079, 94);
            panelCenter_KIA.TabIndex = 2;
            // 
            // groupBoxTask_KIA
            // 
            groupBoxTask_KIA.Controls.Add(textBoxTask_KIA);
            groupBoxTask_KIA.Dock = DockStyle.Fill;
            groupBoxTask_KIA.Location = new Point(0, 0);
            groupBoxTask_KIA.Name = "groupBoxTask_KIA";
            groupBoxTask_KIA.Size = new Size(1079, 94);
            groupBoxTask_KIA.TabIndex = 0;
            groupBoxTask_KIA.TabStop = false;
            groupBoxTask_KIA.Text = "Условие:";
            // 
            // textBoxTask_KIA
            // 
            textBoxTask_KIA.BackColor = SystemColors.Control;
            textBoxTask_KIA.BorderStyle = BorderStyle.None;
            textBoxTask_KIA.Dock = DockStyle.Fill;
            textBoxTask_KIA.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_KIA.Location = new Point(3, 19);
            textBoxTask_KIA.Multiline = true;
            textBoxTask_KIA.Name = "textBoxTask_KIA";
            textBoxTask_KIA.ReadOnly = true;
            textBoxTask_KIA.Size = new Size(1073, 72);
            textBoxTask_KIA.TabIndex = 0;
            textBoxTask_KIA.Text = resources.GetString("textBoxTask_KIA.Text");
            // 
            // panelLeft_KIA
            // 
            panelLeft_KIA.Controls.Add(groupBoxInPut_KIA);
            panelLeft_KIA.Dock = DockStyle.Left;
            panelLeft_KIA.Location = new Point(0, 174);
            panelLeft_KIA.Name = "panelLeft_KIA";
            panelLeft_KIA.Size = new Size(616, 609);
            panelLeft_KIA.TabIndex = 3;
            // 
            // groupBoxInPut_KIA
            // 
            groupBoxInPut_KIA.Controls.Add(dataGridViewInPut_KIA);
            groupBoxInPut_KIA.Dock = DockStyle.Fill;
            groupBoxInPut_KIA.Location = new Point(0, 0);
            groupBoxInPut_KIA.Name = "groupBoxInPut_KIA";
            groupBoxInPut_KIA.Size = new Size(616, 609);
            groupBoxInPut_KIA.TabIndex = 0;
            groupBoxInPut_KIA.TabStop = false;
            groupBoxInPut_KIA.Text = "Ввод:";
            // 
            // dataGridViewInPut_KIA
            // 
            dataGridViewInPut_KIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInPut_KIA.ColumnHeadersVisible = false;
            dataGridViewInPut_KIA.Dock = DockStyle.Fill;
            dataGridViewInPut_KIA.Location = new Point(3, 19);
            dataGridViewInPut_KIA.Name = "dataGridViewInPut_KIA";
            dataGridViewInPut_KIA.ReadOnly = true;
            dataGridViewInPut_KIA.RowHeadersVisible = false;
            dataGridViewInPut_KIA.Size = new Size(610, 587);
            dataGridViewInPut_KIA.TabIndex = 0;
            // 
            // splitterPanels_KIA
            // 
            splitterPanels_KIA.Location = new Point(616, 174);
            splitterPanels_KIA.Name = "splitterPanels_KIA";
            splitterPanels_KIA.Size = new Size(3, 609);
            splitterPanels_KIA.TabIndex = 4;
            splitterPanels_KIA.TabStop = false;
            // 
            // panelRight_KIA
            // 
            panelRight_KIA.Controls.Add(groupBoxOutPut_KIA);
            panelRight_KIA.Dock = DockStyle.Fill;
            panelRight_KIA.Location = new Point(619, 174);
            panelRight_KIA.Name = "panelRight_KIA";
            panelRight_KIA.Size = new Size(460, 609);
            panelRight_KIA.TabIndex = 5;
            // 
            // groupBoxOutPut_KIA
            // 
            groupBoxOutPut_KIA.Controls.Add(dataGridViewOutPut_KIA);
            groupBoxOutPut_KIA.Dock = DockStyle.Fill;
            groupBoxOutPut_KIA.Location = new Point(0, 0);
            groupBoxOutPut_KIA.Name = "groupBoxOutPut_KIA";
            groupBoxOutPut_KIA.Size = new Size(460, 609);
            groupBoxOutPut_KIA.TabIndex = 0;
            groupBoxOutPut_KIA.TabStop = false;
            groupBoxOutPut_KIA.Text = "Вывод:";
            // 
            // dataGridViewOutPut_KIA
            // 
            dataGridViewOutPut_KIA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutPut_KIA.ColumnHeadersVisible = false;
            dataGridViewOutPut_KIA.Dock = DockStyle.Fill;
            dataGridViewOutPut_KIA.Location = new Point(3, 19);
            dataGridViewOutPut_KIA.Name = "dataGridViewOutPut_KIA";
            dataGridViewOutPut_KIA.ReadOnly = true;
            dataGridViewOutPut_KIA.RowHeadersVisible = false;
            dataGridViewOutPut_KIA.Size = new Size(454, 587);
            dataGridViewOutPut_KIA.TabIndex = 0;
            // 
            // openFileDialogTask_KIA
            // 
            openFileDialogTask_KIA.FileName = "openFileDialog1";
            openFileDialogTask_KIA.FileOk += openFileDialog1_FileOk;
            // 
            // toolTipButton_KIA
            // 
            toolTipButton_KIA.IsBalloon = true;
            toolTipButton_KIA.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 783);
            Controls.Add(panelRight_KIA);
            Controls.Add(splitterPanels_KIA);
            Controls.Add(panelLeft_KIA);
            Controls.Add(panelCenter_KIA);
            Controls.Add(panelTop_KIA);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 7 | Кучук И.А.";
            WindowState = FormWindowState.Maximized;
            Load += FormMain_Load;
            panelTop_KIA.ResumeLayout(false);
            panelCenter_KIA.ResumeLayout(false);
            groupBoxTask_KIA.ResumeLayout(false);
            groupBoxTask_KIA.PerformLayout();
            panelLeft_KIA.ResumeLayout(false);
            groupBoxInPut_KIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInPut_KIA).EndInit();
            panelRight_KIA.ResumeLayout(false);
            groupBoxOutPut_KIA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutPut_KIA).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_KIA;
        private Button buttonSaveFile_KIA;
        private Panel panelCenter_KIA;
        private Panel panelLeft_KIA;
        private Splitter splitterPanels_KIA;
        private Panel panelRight_KIA;
        private Button buttonHelp_KIA;
        private Button buttonDone_KIA;
        private Button buttonOpenFile_KIA;
        private GroupBox groupBoxTask_KIA;
        private TextBox textBoxTask_KIA;
        private GroupBox groupBoxInPut_KIA;
        private DataGridView dataGridViewInPut_KIA;
        private GroupBox groupBoxOutPut_KIA;
        private DataGridView dataGridViewOutPut_KIA;
        private OpenFileDialog openFileDialogTask_KIA;
        private ToolTip toolTipButton_KIA;
        private SaveFileDialog saveFileDialogMatrix_KIA;
    }
}
