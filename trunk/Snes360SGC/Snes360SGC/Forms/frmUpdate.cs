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
        public frmUpdate()
        {
            InitializeComponent();

            VersionInfo version = new VersionInfo();

            version.getNewestVersion();

        }
    }
}
