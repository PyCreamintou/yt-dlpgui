namespace ffmpegui
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
            btnAdd = new Button();
            label1 = new Label();
            lstNames = new ListBox();
            txtLink = new TextBox();
            label2 = new Label();
            yt_output = new RichTextBox();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(332, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "add link";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(177, 82);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 1;
            label1.Text = "Something";
            // 
            // lstNames
            // 
            lstNames.FormattingEnabled = true;
            lstNames.Location = new Point(177, 100);
            lstNames.Name = "lstNames";
            lstNames.Size = new Size(415, 94);
            lstNames.TabIndex = 2;
            // 
            // txtLink
            // 
            txtLink.Location = new Point(269, 262);
            txtLink.Name = "txtLink";
            txtLink.Size = new Size(203, 23);
            txtLink.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 179);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 5;
            label2.Text = "yt-dlp output";
            // 
            // yt_output
            // 
            yt_output.Location = new Point(12, 214);
            yt_output.Name = "yt_output";
            yt_output.Size = new Size(211, 236);
            yt_output.TabIndex = 6;
            yt_output.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 462);
            Controls.Add(yt_output);
            Controls.Add(label2);
            Controls.Add(txtLink);
            Controls.Add(lstNames);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private ListBox lstNames;
        private TextBox txtLink;
        private Label label2;
        private RichTextBox yt_output;
    }
}
