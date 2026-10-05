using System;
using System.Diagnostics;
//using System.Xml.Linq;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace yt_dlpgui
{
    public partial class Form1 : Form
    {
        private Process yt;
        
        public Form1()
        {
            InitializeComponent();


        }
        // yt-dlp.exe -P "<path>" -t <ext> -o "<name>" <url>
        private string SetArgsYt()
        {
            string yt_arguments = "";
            // path
            if (!string.IsNullOrWhiteSpace(FilePathTextbox.Text))
            {
                yt_arguments += $"-P \"{FilePathTextbox.Text}\" ";
            }
            // ext
            if (!string.IsNullOrWhiteSpace(FileFormatCombobox.Text))
            {
                yt_arguments += $"-t {FileFormatCombobox.Text} ";
            }
            // output name
            if (!string.IsNullOrWhiteSpace(FileNameTextbox.Text))
            {
                yt_arguments += $"-o \"{FileNameTextbox.Text}\" ";
            }
            // url
            if (!string.IsNullOrWhiteSpace(txtLink.Text))
            {
                yt_arguments += $"{txtLink.Text}";
            }

            return yt_arguments;
            
        }

        private void ValidateUrl()
        {
            string message = "You did not enter video url.";
            string caption = "Error detected in url";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            MessageBox.Show(message, caption, buttons);
        }
        private void StartYt(string fileName, string arguments)
        {
            try
            {
                yt = new Process();

                yt.StartInfo.FileName = fileName;
                yt.StartInfo.Arguments = arguments;
                yt.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                yt.StartInfo.RedirectStandardOutput = true;
                yt.StartInfo.RedirectStandardError = true;

                yt.OutputDataReceived += (sender, e) => YtLogReceived(e.Data);
                yt.ErrorDataReceived += (sender, e) => YtLogReceived(e.Data);

                yt.Start();

                yt.BeginOutputReadLine();
                yt.BeginErrorReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void YtLogReceived(string data)
        {
            if (data == null) return;
            if (YtOutput.InvokeRequired)
            {
                // yt_output.Invoke(new Action<string>(YtLogReceived), data);
                YtOutput.BeginInvoke(new Action(() => YtLogReceived(data)));
                return;
            }
            YtOutput.AppendText(data + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLink.Text))
            {
                if (YtOutput.Text.Length > 0)
                {
                    YtOutput.Clear();
                }

                StartYt(Path.Combine(AppContext.BaseDirectory, "yt-dlp.exe"), SetArgsYt());
            }
            else
            {
                ValidateUrl();
            }

        }

    }
}
