using System;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using System.Xml.Linq;
//using static System.Runtime.InteropServices.JavaScript.JSType;

namespace yt_dlpgui
{
    public partial class MainWindow : Form
    {
        private Process yt;

        private string errorText;

        public MainWindow()
        {
            InitializeComponent();


        }
        // yt-dlp.exe -P "<path>" -t <ext> -S "res:<quality>,ext" -o "<name>" <url>
        private string SetArgsYt()
        {
            string yt_arguments = "";
            // -P "<path>"
            if (!string.IsNullOrWhiteSpace(FilePathTextbox.Text))
            {
                yt_arguments += $"-P \"{FilePathTextbox.Text}\" ";
            }
            // -t <ext> 
            if (!string.IsNullOrWhiteSpace(FileFormatCombobox.Text) & FileFormatCombobox.Items.Contains(FileFormatCombobox.Text))
            {
                yt_arguments += $"-t {FileFormatCombobox.Text} ";
            }
            // -S "res:<quality>,ext"
            if (!string.IsNullOrWhiteSpace(FileQualityComboBox.Text) & FileQualityComboBox.Items.Contains(FileQualityComboBox.Text))
            {
                yt_arguments += $"-S \"res:{FileQualityComboBox.Text.Trim("p")}\" ";
            }
            // -o "<name>"
            if (!string.IsNullOrWhiteSpace(FileNameTextbox.Text))
            {
                yt_arguments += $"-o \"{FileNameTextbox.Text}\" ";
            }
            // <url>
            if (!string.IsNullOrWhiteSpace(txtLink.Text))
            {
                yt_arguments += $"{txtLink.Text}";
            }

            return yt_arguments;

        }

        private void btnGetDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePathTextbox.Text = dialog.SelectedPath;
            }
        }

        private void MessageBoxCreate(string message, string caption)
        {
            //message = message ?? "Error";
            //caption = caption ?? "Error";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            MessageBox.Show(message, caption, buttons);
        }
        private void StartYt(string fileName, string arguments)
        {
            try
            {
                yt = new Process();

                yt.StartInfo.FileName = fileName;
                yt.StartInfo.Arguments = arguments;
                yt.StartInfo.UseShellExecute = false;
                yt.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                yt.StartInfo.RedirectStandardOutput = true;
                yt.StartInfo.RedirectStandardError = true;
                yt.StartInfo.CreateNoWindow = true;

                yt.EnableRaisingEvents = true;

                yt.OutputDataReceived += new DataReceivedEventHandler(YtOutputHandler);
                yt.ErrorDataReceived  += new DataReceivedEventHandler(YtErrorHandler);

                yt.Start();

                yt.BeginOutputReadLine();
                yt.BeginErrorReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void YtOutputHandler(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data)) return;
            if (YtOutput.InvokeRequired)
            {
                // yt_output.Invoke(new Action<string>(YtLogReceived), data);
                YtOutput.BeginInvoke(new Action(() => YtOutputHandler(sender, e)));
                return;
            }
            YtOutput.AppendText(e.Data + Environment.NewLine);
        }
        private void YtErrorHandler(object sender, DataReceivedEventArgs e)
        {
            if (string.IsNullOrEmpty(e.Data)) return;
            errorText += e.Data + Environment.NewLine;

            if (errorText.Contains("ERROR: "))
            {
                MessageBoxCreate(errorText, "yt-dlp Error");
            }
            errorText = string.Empty;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLink.Text))
            {
                if (YtOutput.Text.Length > 0)
                {
                    YtOutput.Clear();
                }

                StartYt(Path.Combine(AppContext.BaseDirectory, "yt-dlp.exe"), SetArgsYt());
            }

        }
    }
}
