using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Snes360SGC.Forms;

namespace Snes360SGC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            //Set Title
            this.Text = "Snes360 Save Game Converter v" + this.ProductVersion.ToString().Remove(5, 2);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout AboutForm = new frmAbout();

            AboutForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate UpdateForm = new frmUpdate();

            UpdateForm.ShowDialog();
        }

        private void btnMainBuild_Click(object sender, EventArgs e)
        {
            pnlMainBackground.Visible = false;
            tabControl1.Visible = true;

            tabControl1.SelectedIndex = 0;
            
        }

        private void btnMainExtract_Click(object sender, EventArgs e)
        {
            pnlMainBackground.Visible = false;

            tabControl1.Visible = true;

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSRMLocation.Text = "";
            txtGameName.Text = "";
            txtOutputFile.Text = "";
        }

        private void btnSRMBrowse_Click(object sender, EventArgs e)
        {
            dialogInputFile.Title = "Select Input SRM file:";
            dialogInputFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialogInputFile.FileName = ".srm";
            dialogInputFile.Multiselect = false;
            dialogInputFile.Filter = "Snes Save Game|*.srm|All Files|*.*";

            if (dialogInputFile.ShowDialog() == DialogResult.OK)
            {
                txtSRMLocation.Text = dialogInputFile.FileName;
            }
        }

        private void btnOutputBrowse_Click(object sender, EventArgs e)
        {
            dialogOutputFile.Title = "Select Output Snes360 file:";
            dialogOutputFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            dialogOutputFile.FileName = "";
            dialogOutputFile.Filter = "Snes360 Save Game|*.*";

            if (dialogOutputFile.ShowDialog() == DialogResult.OK)
            {
                txtOutputFile.Text = dialogInputFile.FileName;
            }
        }
    }
}
