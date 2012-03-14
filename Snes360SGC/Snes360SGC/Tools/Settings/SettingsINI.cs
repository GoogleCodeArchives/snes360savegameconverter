using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Snes360SGC.Tools.Settings
{
	class Settings
	{
		const string SETTINGS_FILE = "settings.ini";

		#region settings variables

		static Settings instance;// = new Settings();

		private string _TEMP_DIRECTORY;
		private bool _check_for_updates_auto;

        internal string getTempDirectory() { return this._TEMP_DIRECTORY; }

        internal bool getCheckForUpdatesAuto() { return this._check_for_updates_auto; }

		#endregion

		#region Constructor

		public Settings()
		{   
            Init();
            read();
		}

		static public Settings getInstance()
		{
			//static Settings singleton = null;
			return instance;
		}

		#endregion

		#region functions

		private void Init()
		{
			_TEMP_DIRECTORY = Path.GetTempPath();

		}

		#region File Functions

		private bool writeSettingsFile()
		{
            bool result = false;

            StreamWriter settingsWriter = new StreamWriter(File.Open(SETTINGS_FILE, FileMode.Create, FileAccess.Write));

            try
            {
                //Settings File Contents
                settingsWriter.WriteLine("<Directories>");
                settingsWriter.WriteLine(String.Format("Temp Directory={0}", _TEMP_DIRECTORY.ToString()));

                settingsWriter.WriteLine("<Options>");

                result = true;
            }
            catch
            {
                result = false;
            }
            finally
            {
                if(settingsWriter != null)
                    settingsWriter.Close();
            }

			return result;
		}

		static private bool readSettingsFile()
		{
			return false;
		}

		#endregion

		#region Private Functions

		private void setDefaults()
		{
			_TEMP_DIRECTORY = Path.GetTempPath();
		    _check_for_updates_auto = false;

			writeSettingsFile();
		}

		#endregion

		#region Public Function

		public bool read()
		{
			bool result = false;

			if (File.Exists(SETTINGS_FILE))
			{
				readSettingsFile();
				result = true;
			}
			else
			{
				setDefaults();
				result = true;
			}

			return result;
		}

		public bool write()
		{
			bool success = false;

			writeSettingsFile();

			return success;
		}

		#endregion

		#endregion
	}
}
