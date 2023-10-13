using Octokit;
using SYS_AutoUpdater.Properties;
using System.IO.Compression;
using System.Net;
using System.Net.Sockets;

namespace SYS_AutoUpdater
{
    public partial class SYS_AutoUpdater : Form
    {
        public static ViewerState Executor = new();
        public static Socket SwitchConnection = new(SocketType.Stream, ProtocolType.Tcp);
        public SYS_AutoUpdater()
        {
            InitializeComponent();
            label1.Text = Settings.Default.AtmosVers;
            label2.Text = Settings.Default.HekateVers;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UpdateProgress(10, 100);
            UpdateProgress(25, 100);
            GitHubClient atmosphereClient = new(new ProductHeaderValue("Atmosphere"));
            var AMSreleases = await atmosphereClient.Repository.Release.GetAll("Atmosphere-NX", "Atmosphere");
            var latestAMS = AMSreleases[0];
            var res = string.Join("", latestAMS.Assets[0].Name);
#pragma warning disable SYSLIB0014 // Type or member is obsolete
            WebClient webClient = new();
#pragma warning restore SYSLIB0014 // Type or member is obsolete
            webClient.DownloadFile($"https://github.com/Atmosphere-NX/Atmosphere/releases/download/{AMSreleases[0].TagName}/{res}", $"atmosphere-{AMSreleases[0].TagName}.zip");
            UpdateProgress(50, 100);
            GitHubClient hekateClient = new(new ProductHeaderValue("Hekate"));
            var CTCreleases = await hekateClient.Repository.Release.GetAll("CTCaer", "Hekate");
            var ogCTC = CTCreleases[0].TagName;
            res = string.Join("", CTCreleases[0].Assets[0].Name);
#pragma warning disable SYSLIB0014 // Type or member is obsolete
            webClient = new();
#pragma warning restore SYSLIB0014 // Type or member is obsolete
            webClient.DownloadFile($"https://github.com/CTCaer/hekate/releases/download/{ogCTC}/{res}", $"hekate-{CTCreleases[0].TagName}.zip");
            UpdateProgress(90, 100);

            label1.Text = "Atmosphere Version: " + AMSreleases[0].TagName + Environment.NewLine + $"Released On: {AMSreleases[0].CreatedAt.Date.ToShortDateString()}";
            label2.Text = "Hekate Version: " + CTCreleases[0].TagName + Environment.NewLine + $"Released On: {CTCreleases[0].CreatedAt.Date.ToShortDateString()}";
            Settings.Default.AtmosVers = label1.Text;
            Settings.Default.HekateVers = label2.Text;
            Settings.Default.Save();
            UpdateProgress(100, 100);

            var amsPath = $"atmosphere-{AMSreleases[0].TagName}";
            var hekPath = $"hekate-{CTCreleases[0].TagName}";

            if (Directory.Exists(amsPath))
            {
                Directory.Delete(amsPath, true);
                ZipFile.ExtractToDirectory($"{amsPath}" + ".zip", amsPath);
            }
            if (!Directory.Exists(amsPath))
                ZipFile.ExtractToDirectory($"{amsPath}" + ".zip", amsPath);

            if (Directory.Exists(hekPath))
            {
                Directory.Delete(hekPath, true);
                ZipFile.ExtractToDirectory($"{hekPath}" + ".zip", hekPath);
            }
            if (!Directory.Exists(hekPath))
                ZipFile.ExtractToDirectory($"{hekPath}" + ".zip", hekPath);
        }

        private void UpdateProgress(int currProgress, int maxProgress)
        {
            var value = (100 * currProgress) / maxProgress;
            if (progressBar1.InvokeRequired)
                progressBar1.Invoke(() => progressBar1.Value = value);
            else
                progressBar1.Value = value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!SwitchConnection.Connected)
            {
                try
                {
                    SwitchConnection.Connect(textBox1.Text, 6000);
                    if (SwitchConnection.Connected)
                        button2.Text = "Disconnect";
                }
                catch (SocketException err)
                {
                    MessageBox.Show($"{err.Message}{Environment.NewLine}Ensure {textBox1.Text} is correct before attempting to connect!");
                }
            }
            else
            {
                SwitchConnection.Disconnect(true);
                button2.Text = "Connect";
            }
        }
    }
}