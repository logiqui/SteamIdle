using System;
using System.Windows.Forms;
using Steamworks;

namespace SteamIdle
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void TextBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void StartIdle(uint appId)
        {
            try
            {
                Environment.SetEnvironmentVariable("SteamAppId", appId.ToString());

                SteamClient.Init(appId);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message, "Error");
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.PicApp.Load("http://cdn.akamai.steamstatic.com/steam/apps/" + this.TextBoxID.Text + "/header.jpg");
                this.StartIdle(uint.Parse(this.TextBoxID.Text));

                this.Text = "Running App: " + this.TextBoxID.Text;
                this.TrayApp.Text = "Running App: " + this.TextBoxID.Text;
                this.LabelID.Visible = false;
                this.TextBoxID.Visible = false;
                this.StartButton.Visible = false;
            }
            catch (System.Exception)
            {
                MessageBox.Show("Invalid App ID", "Error");
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            bool MouseNotOnTaskbar = Screen.GetWorkingArea(this).Contains(Cursor.Position);

            if (this.WindowState == FormWindowState.Minimized && MouseNotOnTaskbar)
            {
                this.ShowInTaskbar = false;
                this.TrayApp.Visible = true;
            }
        }

        private void TrayApp_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            bool IsButton = e.Button == MouseButtons.Left;

            if (IsButton)
            {
                this.WindowState = FormWindowState.Normal;

                if (this.WindowState == FormWindowState.Normal)
                {
                    this.ShowInTaskbar = true;
                    this.TrayApp.Visible = false;
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.TrayApp.Visible = false;

            SteamClient.Shutdown();
            Application.Exit();
            Environment.Exit(0);
        }
    }
}
