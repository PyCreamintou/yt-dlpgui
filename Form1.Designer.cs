namespace yt_dlpgui
{
    partial class Form1
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
            YtOutput = new RichTextBox();
            groupBox1 = new GroupBox();
            splitContainer1 = new SplitContainer();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            FileFormatCombobox = new ComboBox();
            FilePathTextbox = new TextBox();
            FileNameTextbox = new TextBox();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnAdd = new Button();
            txtLink = new TextBox();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // YtOutput
            // 
            YtOutput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            YtOutput.BackColor = SystemColors.Window;
            YtOutput.ImeMode = ImeMode.NoControl;
            YtOutput.Location = new Point(6, 22);
            YtOutput.Name = "YtOutput";
            YtOutput.ReadOnly = true;
            YtOutput.Size = new Size(188, 189);
            YtOutput.TabIndex = 6;
            YtOutput.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitContainer1);
            groupBox1.Location = new Point(254, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(265, 116);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Video Info";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(FileFormatCombobox);
            splitContainer1.Panel2.Controls.Add(FilePathTextbox);
            splitContainer1.Panel2.Controls.Add(FileNameTextbox);
            splitContainer1.Size = new Size(259, 94);
            splitContainer1.SplitterDistance = 67;
            splitContainer1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1, 35);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 2;
            label4.Text = "FIle Format";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 61);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Path";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 6);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FileFormatCombobox
            // 
            FileFormatCombobox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FileFormatCombobox.FormattingEnabled = true;
            FileFormatCombobox.Items.AddRange(new object[] { "mp3", "aac", "mp4", "mkv" });
            FileFormatCombobox.Location = new Point(2, 32);
            FileFormatCombobox.Name = "FileFormatCombobox";
            FileFormatCombobox.Size = new Size(183, 23);
            FileFormatCombobox.TabIndex = 11;
            // 
            // FilePathTextbox
            // 
            FilePathTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FilePathTextbox.Location = new Point(2, 61);
            FilePathTextbox.Name = "FilePathTextbox";
            FilePathTextbox.Size = new Size(183, 23);
            FilePathTextbox.TabIndex = 1;
            // 
            // FileNameTextbox
            // 
            FileNameTextbox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            FileNameTextbox.Location = new Point(2, 3);
            FileNameTextbox.Name = "FileNameTextbox";
            FileNameTextbox.Size = new Size(183, 23);
            FileNameTextbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(YtOutput);
            groupBox2.Location = new Point(12, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 217);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "yt-dlp output";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(6, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete video";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(6, 51);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Download";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button_Click;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(6, 22);
            txtLink.Name = "txtLink";
            txtLink.PlaceholderText = "Enter Youtube link";
            txtLink.Size = new Size(203, 23);
            txtLink.TabIndex = 3;
            txtLink.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtLink);
            groupBox3.Controls.Add(btnDelete);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Location = new Point(18, 24);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(217, 168);
            groupBox3.TabIndex = 12;
            groupBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(814, 461);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MinimumSize = new Size(830, 500);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox YtOutput;
        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private TextBox FileNameTextbox;
        private TextBox FilePathTextbox;
        private ComboBox FileFormatCombobox;
        private Label label3;
        private Label label4;
        private Label label1;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtLink;
        private GroupBox groupBox3;
    }
}
