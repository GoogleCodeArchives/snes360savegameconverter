using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Snes360SGC.Tools.VersionInfo;

namespace Snes360SGC.Forms
{
    public partial class frmUpdate : Form
    {

        VersionInfo version = new VersionInfo();

        VersionInfo.versionInfoStruct InstalledVersionInfo = new VersionInfo.versionInfoStruct();
        VersionInfo.versionInfoStruct LatestVersionInfo = new VersionInfo.versionInfoStruct();

        public frmUpdate()
        {
            InitializeComponent();

            Init();

            //version.getNewestVersion();



        }

        private void Init()
        {
            txtInstalledVersion.Text = "";
            txtLatestVersion.Text = "Click 'Check for Updates'";

            

            InstalledVersionInfo = version.getCurrentVersion();
            txtInstalledVersion.Text = InstalledVersionInfo.getFullVersion();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
