using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Snes360SGC.Tools;
using Snes360SGC.Tools.SettingsManager;

namespace Snes360SGC
{
    public partial class SplashScreen : Form
    {
        internal bool _isLoaded { get; set; }
        private int _ticksPassed;
        const int MIN_TICKS_TILL_LOAD = 36;

        internal SettingsManager SettingsLocal = new SettingsManager(true);// = Settings.getInstance();

        public SplashScreen()
        {
            InitializeComponent();

            lblVersion.Text = "v" + this.ProductVersion.ToString().Remove(5, 2);

            Init();

            loadStuff();
        }

        private void Init()
        {
            _isLoaded = false;
            _ticksPassed = 0;
            tmrStartUp.Enabled = true;
            tmrStartUp.Start();
            
        }

        private void loadStuff()
        {
            //SettingsFile = new Settings();
            //if (!SettingsFile.read())
            //{
                
            //    MessageBox.Show("Error occurred reading settings XML file. \n\n Try removing \"Settings.xml\"", "Error");
            //}
            //else
            //{
                //SettingsFile = SettingsINI.getInstance();
                _isLoaded = true;
            //}
        }

        private void tmrStartUp_Tick(object sender, EventArgs e)
        {
            if (_isLoaded)
            {
                if (_ticksPassed >= MIN_TICKS_TILL_LOAD)
                {
                    this.Close();
                }
            }

            _ticksPassed++;

        }

        private void SplashScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            //startApp();
        }

        
    }
}
