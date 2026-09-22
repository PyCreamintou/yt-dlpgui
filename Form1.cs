using System;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ffmpegui
{
    public partial class Form1 : Form
    {
        private Process yt;
        public Form1()
        {
            InitializeComponent();

            
        }
        private void StartYt(string fileName, string arguments)
        {
            yt = new Process();

            yt.StartInfo.FileName = fileName;
            yt.StartInfo.Arguments = arguments;
            yt.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            yt.StartInfo.RedirectStandardOutput = true;
            yt.StartInfo.RedirectStandardError = true;

            yt.OutputDataReceived += (sender, e) => YtLogReceived(e.Data);
            yt.ErrorDataReceived  += (sender, e) => YtLogReceived(e.Data);

            yt.Start();

            yt.BeginOutputReadLine();
            yt.BeginErrorReadLine();

        }
        private void YtLogReceived(string data)
        {
            if (data == null) return;
            if (yt_output.InvokeRequired)
            {
                // yt_output.Invoke(new Action<string>(YtLogReceived), data);
                yt_output.BeginInvoke(new Action(() => YtLogReceived(data)));
                return;
            }

            yt_output.AppendText(data + Environment.NewLine);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLink.Text) && !lstNames.Items.Contains(txtLink.Text))
                StartYt(Path.Combine(AppContext.BaseDirectory, "yt-dlp.exe"), txtLink.Text);
        }
    }
}
