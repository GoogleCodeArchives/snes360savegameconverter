using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Snes360SGC.Tools;
using Snes360SGC.Tools.VersionManager;
using Snes360SGC.Tools.SettingsManager;

namespace Snes360SGC.Forms
{
    public partial class frmUpdate : Form
    {
        SettingsManager localSettings = new SettingsManager(false);// new Settings();

        VersionManager VersionManagement = new VersionManager();

        VersionInfo.versionInfoStruct InstalledVersionInfo = new VersionInfo.versionInfoStruct();
        VersionInfo.versionInfoStruct LatestVersionInfo = new VersionInfo.versionInfoStruct();

        string TEMP_DIRECTORY;

        string locationChangeLog = "";

        public frmUpdate()
        {   
            InitializeComponent();

            //localSettings = SettingsINI.getInstance();

            Init();
        }

        private void Init()
        {
            TEMP_DIRECTORY = localSettings.getTmpDirectory().ToString();// localSettings.getInstance().TEMP_DIRECTORY;

            if(!Directory.Exists(TEMP_DIRECTORY))
                Directory.CreateDirectory(TEMP_DIRECTORY);

            txtLatestVersion.BackColor = txtLatestVersion.BackColor;

            txtInstalledVersion.Text = "";
            txtLatestVersion.Text = "Check for Updates";

            InstalledVersionInfo = VersionManagement.getInstalledVersionInfo();
            txtInstalledVersion.Text = VersionManagement.getInstalledFullVersionString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setLatestVersionFont(Color newColor, FontStyle newFontStyle)
        {
            txtLatestVersion.ForeColor = newColor;
            txtLatestVersion.Font = new Font(this.Font, newFontStyle);
        }

        private void getChangeLog()
        {
            locationChangeLog = VersionManagement.getChangeLog(TEMP_DIRECTORY);

            if (locationChangeLog != "")
            {
                btnChangeLog.Enabled = true;
            }
            else
            {
                btnChangeLog.Enabled = false;
            }
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            setLatestVersionFont(Color.Black, FontStyle.Regular);

            txtLatestVersion.Text = "Checking...";
            LatestVersionInfo = VersionManagement.getNewestVersion(TEMP_DIRECTORY);


            if (VersionManagement.checkIfNewer(InstalledVersionInfo, LatestVersionInfo))
            {
                btnUpdate.Enabled = true;

                getChangeLog();

                setLatestVersionFont(Color.Green, FontStyle.Bold);
            }

            txtLatestVersion.Text = LatestVersionInfo.getFullVersion();
        }

        private void btnChangeLog_Click(object sender, EventArgs e)
        {
            if (File.Exists(locationChangeLog))
            {
                System.Diagnostics.Process.Start(locationChangeLog);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NOT YET IMPLEMENTED!");
        }
    }

}
