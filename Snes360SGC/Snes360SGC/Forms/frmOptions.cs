using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Snes360SGC.Tools.SettingsManager;

namespace Snes360SGC.Forms
{
    public partial class frmOptions : Form
    {

        SettingsManager localSettings = new SettingsManager(false);

        public frmOptions()
        {
            InitializeComponent();
            refreshSettingsFields();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDefaults_Click(object sender, EventArgs e)
        {
            string Message = "Are you sure you want to reset to defaults?";

            if (MessageBox.Show(Message, "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                localSettings.resetSettings();
                refreshSettingsFields();
            }
        }

        private void refreshSettingsFields()
        {
            txtTmpDirectory.Text = localSettings.getTmpDirectory();
            chkUpdateOnBoot.Checked = localSettings.getUpdateOnBoot();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            txtTmpDirectory.Text = localSettings.getOSTempPath();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void ApplySettings()
        {
            localSettings.setTmpDirectory(txtTmpDirectory.Text);
            localSettings.setUpdateOnBoot(chkUpdateOnBoot.Checked);
            localSettings.saveSettings();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ApplySettings();
            this.Close();
        }

        private void chkUpdateOnBoot_CheckedChanged(object sender, EventArgs e)
        {
            //localSettings.setUpdateOnBoot(chkUpdateOnBoot.Checked);
        }
    }
}
