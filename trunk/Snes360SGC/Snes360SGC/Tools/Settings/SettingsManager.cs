using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using Snes360SGC.Properties;

namespace Snes360SGC.Tools.SettingsManager
{
	public class SettingsManager
	{

		#region settings variables

		static internal string tmpDirectory { get; set; }
		static internal bool updateOnBoot { get; set; }

		#endregion

		#region Constructor

		public SettingsManager(bool doValidateSettings)
		{
            if (doValidateSettings)
            {
                if (!ValidateSettings())
                {
                    setDefaults();
                }
            }

		}

		#endregion

        #region Accessors

        internal string getTmpDirectory() { return Settings.Default._tempDirectory; }
        internal void setTmpDirectory(string value) { Settings.Default._tempDirectory = value; }

        internal bool getUpdateOnBoot() { return Settings.Default._updateOnBoot; }
        internal void setUpdateOnBoot(bool value) { Settings.Default._updateOnBoot = value; }

        #endregion

        #region functions

        private bool ValidateSettings()
        {
            bool result = false;
            string strTempDir = Settings.Default._tempDirectory;

            if (strTempDir != "" && strTempDir != null)
            {
                result = true;
            }

            return result;
        }

		#region Private Functions

		private void setDefaults()
		{
            setTmpDirectory(getOSTempPath());
			setUpdateOnBoot(false);
            saveSettings();
		}

		#endregion

		#region Public Function

        public void saveSettings()
        {
            Settings.Default.Save();
        }

        public void resetSettings()
        {
            setDefaults();
        }

        public string getOSTempPath()
        {
            return Path.GetTempPath();
        }

		#endregion

		#endregion
	}
}
