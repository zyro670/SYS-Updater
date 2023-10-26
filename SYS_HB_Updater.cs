using Octokit;
using SYS_AutoUpdater.Properties;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace SYS_AutoUpdater
{
    public partial class SYS_HB_Updater : Form
    {
        public static ViewerState Executor = new();
        public static Socket SwitchConnection = new(SocketType.Stream, ProtocolType.Tcp);
        public SYS_HB_Updater()
        {
            InitializeComponent();
            label1.Text = Settings.Default.AtmosVers;
            label2.Text = Settings.Default.HekateVers;
            label3.Text = Settings.Default.ldnVers;
            label4.Text = Settings.Default.SysBotBaseVers;
            AMSCheck.Checked = Settings.Default.AMSSelected;
            HekateCheck.Checked = Settings.Default.HekateSelected;
            ldnCheck.Checked = Settings.Default.ldnSelected;
            SbbCheck.Checked = Settings.Default.SbbSelected;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            UpdateProgress(10, 100);
            HttpClient httpClient;
            GitHubClient atmosphereClient = new(new ProductHeaderValue("Atmosphere"));
            var AMSreleases = await atmosphereClient.Repository.Release.GetAll("Atmosphere-NX", "Atmosphere");
            var latestAMS = AMSreleases[0];
            string res = string.Join("", latestAMS.Assets[0].Name);
            if (AMSCheck.Checked)
            {
                Settings.Default.AMSSelected = true;
                httpClient = new();
                var file = await httpClient.GetByteArrayAsync($"https://github.com/Atmosphere-NX/Atmosphere/releases/download/{AMSreleases[0].TagName}/{res}");
                File.WriteAllBytes($"atmosphere-{AMSreleases[0].TagName}.zip", file);
            }
            label1.Text = $"Atmosphere Version: {AMSreleases[0].TagName}";
            label5.Text = $"Released On: {AMSreleases[0].CreatedAt.Date.ToShortDateString()}";
            Settings.Default.AtmosVers = label1.Text;
            var amsPath = $"atmosphere-{AMSreleases[0].TagName}";

            if (checkBox5.Checked)
            {
                if (Directory.Exists(amsPath + ".zip"))
                {
                    ZipFile.ExtractToDirectory($"{amsPath}.zip", amsPath);
                    Directory.Delete(amsPath + ".zip", true);
                }
                if (!Directory.Exists(amsPath + ".zip"))
                    ZipFile.ExtractToDirectory($"{amsPath}.zip", amsPath);
            }

            UpdateProgress(40, 100);
            GitHubClient hekateClient = new(new ProductHeaderValue("Hekate"));
            var CTCreleases = await hekateClient.Repository.Release.GetLatest("CTCaer", "Hekate");
            var ogCTC = CTCreleases.TagName;
            res = string.Join("", CTCreleases.Assets[0].Name);
            if (HekateCheck.Checked)
            {
                Settings.Default.HekateSelected = true;
                httpClient = new();
                var file = await httpClient.GetByteArrayAsync($"https://github.com/CTCaer/hekate/releases/download/{ogCTC}/{res}");
                File.WriteAllBytes($"hekate-{CTCreleases.TagName}.zip", file);
            }
            label2.Text = $"Hekate Version: {CTCreleases.TagName}";
            label6.Text = $"Released On: {CTCreleases.CreatedAt.Date.ToShortDateString()}";
            Settings.Default.HekateVers = label2.Text;
            var hekPath = $"hekate-{CTCreleases.TagName}";
            if (checkBox5.Checked)
            {
                if (Directory.Exists(hekPath + ".zip"))
                {
                    ZipFile.ExtractToDirectory($"{hekPath}.zip", hekPath);
                    Directory.Delete(hekPath + ".zip", true);
                }
                if (!Directory.Exists(hekPath))
                    ZipFile.ExtractToDirectory($"{hekPath}.zip", hekPath);
            }

            UpdateProgress(60, 100);
            GitHubClient ldnClient = new(new ProductHeaderValue("ldn_mitm"));
            var ldnRelease = await ldnClient.Repository.Release.GetLatest("Lusamine", "ldn_mitm");
            var ogldn = ldnRelease.TagName;
            res = string.Join("", ldnRelease.Assets[0].Name);
            if (ldnCheck.Checked)
            {
                Settings.Default.ldnSelected = true;
                httpClient = new();
                var file = await httpClient.GetByteArrayAsync($"https://github.com/Lusamine/ldn_mitm/releases/download/{ogldn}/{res}");
                File.WriteAllBytes($"ldn_mitm-{ldnRelease.TagName}.zip", file);
            }
            label3.Text = $"ldn_mitm Version: {ldnRelease.TagName}";
            label7.Text = $"Released On: {ldnRelease.CreatedAt.Date.ToShortDateString()}";
            Settings.Default.ldnVers = label3.Text;
            var ldnPath = $"ldn_mitm-{ldnRelease.TagName}";
            if (checkBox5.Checked)
            {
                if (Directory.Exists(ldnPath + ".zip"))
                {
                    ZipFile.ExtractToDirectory($"{ldnPath}.zip", ldnPath);
                    Directory.Delete(ldnPath + ".zip", true);
                }
                if (!Directory.Exists(ldnPath + ".zip"))
                    ZipFile.ExtractToDirectory($"{ldnPath}.zip", ldnPath);
            }

            UpdateProgress(80, 100);
            GitHubClient sbbClient = new(new ProductHeaderValue("usb-botbase"));
            var sbbRelease = await sbbClient.Repository.Release.GetLatest("zyro670", "usb-botbase");
            var ogSbb = sbbRelease.TagName;
            res = string.Join("", sbbRelease.Assets[0].Name);
            if (SbbCheck.Checked)
            {
                Settings.Default.SbbSelected = true;
                httpClient = new();
                var file = await httpClient.GetByteArrayAsync($"https://github.com/zyro670/usb-botbase/releases/download/{ogSbb}/{res}");
                File.WriteAllBytes($"usb-botbase-{sbbRelease.TagName}.zip", file);
            }
            label4.Text = $"Hybrid SBB Version: {sbbRelease.TagName}";
            label8.Text = $"Released On: {sbbRelease.CreatedAt.Date.ToShortDateString()}";
            Settings.Default.SysBotBaseVers = label4.Text;
            var sbbPath = $"usb-botbase-{sbbRelease.TagName}";
            if (checkBox5.Checked)
            {
                if (Directory.Exists(sbbPath + ".zip"))
                {
                    ZipFile.ExtractToDirectory($"{sbbPath}.zip", sbbPath);
                    Directory.Delete(sbbPath + ".zip", true);
                }
                if (!Directory.Exists(sbbPath + ".zip"))
                    ZipFile.ExtractToDirectory($"{sbbPath}.zip", sbbPath);
            }

            UpdateProgress(90, 100);
            Settings.Default.Save();
            UpdateProgress(100, 100);
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