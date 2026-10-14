namespace yt_dlpgui
{
    partial class MainWindow
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
            YtOutput = new RichTextBox();
            groupBox1 = new GroupBox();
            splitContainer1 = new SplitContainer();
            label2 = new Label();
            label4 = new Label();
            label1 = new Label();
            label3 = new Label();
            btnGetDirectory = new Button();
            FileQualityComboBox = new ComboBox();
            FileFormatCombobox = new ComboBox();
            FilePathTextbox = new TextBox();
            FileNameTextbox = new TextBox();
            groupBox2 = new GroupBox();
            btnAdd = new Button();
            txtLink = new TextBox();
            toolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // YtOutput
            // 
            YtOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            YtOutput.BackColor = SystemColors.Window;
            YtOutput.ImeMode = ImeMode.NoControl;
            YtOutput.Location = new Point(6, 22);
            YtOutput.Name = "YtOutput";
            YtOutput.ReadOnly = true;
            YtOutput.Size = new Size(287, 189);
            YtOutput.TabIndex = 6;
            YtOutput.Text = "";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitContainer1);
            groupBox1.Location = new Point(12, 62);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 144);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Video Info";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(3, 19);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(label4);
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(label3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnGetDirectory);
            splitContainer1.Panel2.Controls.Add(FileQualityComboBox);
            splitContainer1.Panel2.Controls.Add(FileFormatCombobox);
            splitContainer1.Panel2.Controls.Add(FilePathTextbox);
            splitContainer1.Panel2.Controls.Add(FileNameTextbox);
            splitContainer1.Size = new Size(301, 122);
            splitContainer1.SplitterDistance = 68;
            splitContainer1.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Location = new Point(3, 95);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Quality";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(4, 67);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 2;
            label4.Text = "FIle Format";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(4, 35);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Path";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(4, 6);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Name";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGetDirectory
            // 
            btnGetDirectory.FlatStyle = FlatStyle.System;
            btnGetDirectory.Font = new Font("Segoe UI", 11F);
            btnGetDirectory.Location = new Point(196, 35);
            btnGetDirectory.Name = "btnGetDirectory";
            btnGetDirectory.Size = new Size(28, 27);
            btnGetDirectory.TabIndex = 12;
            btnGetDirectory.Text = "📂";
            toolTip1.SetToolTip(btnGetDirectory, "Choose Path Directory");
            btnGetDirectory.UseVisualStyleBackColor = true;
            btnGetDirectory.Click += btnGetDirectory_Click;
            // 
            // FileQualityComboBox
            // 
            FileQualityComboBox.Anchor = AnchorStyles.None;
            FileQualityComboBox.FormattingEnabled = true;
            FileQualityComboBox.Items.AddRange(new object[] { "144p", "240p", "360p", "480p", "720p", "1080p" });
            FileQualityComboBox.Location = new Point(8, 92);
            FileQualityComboBox.Name = "FileQualityComboBox";
            FileQualityComboBox.Size = new Size(79, 23);
            FileQualityComboBox.TabIndex = 12;
            // 
            // FileFormatCombobox
            // 
            FileFormatCombobox.Anchor = AnchorStyles.None;
            FileFormatCombobox.FormattingEnabled = true;
            FileFormatCombobox.Items.AddRange(new object[] { "mp3", "mp4", "mkv" });
            FileFormatCombobox.Location = new Point(8, 63);
            FileFormatCombobox.Name = "FileFormatCombobox";
            FileFormatCombobox.Size = new Size(79, 23);
            FileFormatCombobox.TabIndex = 11;
            // 
            // FilePathTextbox
            // 
            FilePathTextbox.Anchor = AnchorStyles.None;
            FilePathTextbox.Location = new Point(8, 35);
            FilePathTextbox.Name = "FilePathTextbox";
            FilePathTextbox.Size = new Size(182, 23);
            FilePathTextbox.TabIndex = 1;
            // 
            // FileNameTextbox
            // 
            FileNameTextbox.Anchor = AnchorStyles.None;
            FileNameTextbox.Location = new Point(8, 6);
            FileNameTextbox.Name = "FileNameTextbox";
            FileNameTextbox.Size = new Size(216, 23);
            FileNameTextbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.Controls.Add(YtOutput);
            groupBox2.Location = new Point(12, 232);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(299, 217);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "yt-dlp output";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLightLight;
            btnAdd.Font = new Font("Segoe UI", 14F);
            btnAdd.Location = new Point(407, 406);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(158, 43);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Download";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAddClick;
            // 
            // txtLink
            // 
            txtLink.Anchor = AnchorStyles.None;
            txtLink.Font = new Font("Segoe UI", 13F);
            txtLink.Location = new Point(12, 12);
            txtLink.Name = "txtLink";
            txtLink.PlaceholderText = "Enter Youtube link";
            txtLink.Size = new Size(553, 31);
            txtLink.TabIndex = 3;
            txtLink.TextAlign = HorizontalAlignment.Center;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 400;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(577, 461);
            Controls.Add(txtLink);
            Controls.Add(btnAdd);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainWindow";
            Text = "Yt-dlpgui";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button btnAdd;
        private TextBox txtLink;
        private Label label2;
        private ComboBox FileQualityComboBox;
        private Button btnGetDirectory;
        private ToolTip toolTip1;
    }
}
