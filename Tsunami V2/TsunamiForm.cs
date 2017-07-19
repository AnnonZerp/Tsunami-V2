using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using JRPC_Client;
using XDevkit;

namespace Tsunami_V2
{
    public partial class TsunamiForm : XtraForm
    {
        public static IXboxConsole xbox;
        public static List<User> userList = new List<User>();

        public TsunamiForm()
        {
            InitializeComponent();
            gridControl1.DataSource = userList;
        }

        private void creditLink_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(" Developed by TDW\n Special thanks to Blue for testing\n ---------------------------------------------------------------\n I hope that the release of this tool will hinder skids from selling public code.\n Yes, everything in this tool is public. If anyone tries to sell you an IP Puller for RGH, then they should die. \n Also, Immense is a virgin fuckboy.", "Credits", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (xbox.Connect(out xbox))
            {
                Text = "Tsunami V2 - Connected";
                refreshButton.Enabled = true;
                connectButton.Text = "Connected To Console";
                connectButton.Enabled = false;
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;

            refreshButton.Enabled = false;
            
            userList.Clear();
            
            if(xbox.XamGetCurrentTitleId().ToString("X") == "415608CB") //MW3
            {
                labelControl1.Text = "Pulled From: Modern Warfare 3";
                IPCode.FetchMW3();
            }
            
            else if (xbox.XamGetCurrentTitleId().ToString("X") == "41560817") //MW2
            {
                labelControl1.Text = "Pulled From: Modern Warfare 2";
                IPCode.FetchMW2();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "415607E6") //MW
            {
                labelControl1.Text = "Pulled From: Modern Warfare";
                IPCode.FetchMW();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "4156091D") //BO3
            {
                labelControl1.Text = "Pulled From: Black Ops III";
                IPCode.FetchBO3();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "415608C3") //BO2
            {
                labelControl1.Text = "Pulled From: Black Ops II";
                IPCode.FetchBO2();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "41560855") //BO
            {
                labelControl1.Text = "Pulled From: Black Ops";
                IPCode.FetchBO();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "415608FC") //Ghosts
            {
                labelControl1.Text = "Pulled From: Ghosts";
                IPCode.FetchGhosts();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "41560914") //AW
            {
                labelControl1.Text = "Pulled From: Advanced Warfare";
                IPCode.FetchAW();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "4156081C") //WAW
            {
                labelControl1.Text = "Pulled From: World at War";
                IPCode.FetchWAW();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "4D5307E6") //Halo 3
            {
                labelControl1.Text = "Pulled From: Halo 3";
                IPCode.FetchH3();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "4D53085B") //Halo Reach
            {
                labelControl1.Text = "Pulled From: Halo Reach";
                IPCode.FetchHR();
            }

            else if (xbox.XamGetCurrentTitleId().ToString("X") == "545408A7") //GTA V
            {
                labelControl1.Text = "Pulled From: Grand Theft Auto V";
                IPCode.FetchGTAV();
            }

            gridControl1.DataSource = userList;
            refreshButton.Enabled = true;
        }

        private void gridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.C)
            {
                Clipboard.SetText(gridView1.GetFocusedDisplayText());
                e.Handled = true;
            }
        }

        private void TsunamiForm_Load(object sender, EventArgs e)
        {

        }
    }
}
