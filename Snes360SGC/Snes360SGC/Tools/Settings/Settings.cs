using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace Snes360SGC.Tools.Settings
{
	public class SettingsXML
	{
		const string SETTINGS_FILE = "settings.xml";

		#region settings variables

		static SettingsXML instance = new SettingsXML();

		static internal string TEMP_DIRECTORY { get; set; }
		static internal bool check_for_updates_auto { get; set; }

		#endregion

		#region Constructor

		public SettingsXML()
		{
			read();
		}

		static public SettingsXML getInstance()
		{
            //instanc
			//static Settings singleton = null;
			return instance;
		}

		#endregion

		#region functions

		static private void Init()
		{
			TEMP_DIRECTORY = Path.GetTempPath();

		}

		#region File Functions

		static private bool readSettingsFile()
		{
			bool success = false;

			XmlTextReader SettingsXMLReader = new XmlTextReader(SETTINGS_FILE);
			
			while (SettingsXMLReader.Read())
			{
				XmlNodeType nType = SettingsXMLReader.NodeType;

				if (nType == XmlNodeType.Element)
				{
					if (SettingsXMLReader.HasAttributes)
					{
						for (int i = 0; i < SettingsXMLReader.AttributeCount; i++)
						{
							switch (SettingsXMLReader.GetAttribute(i))
							{
								case "Temp_Directory":
									TEMP_DIRECTORY = SettingsXMLReader.Value;
									break;
								default:
									break;
							}
						}
					}
				}
			}

			return success;
		}

		static private bool writeSettingsFile()
		{
			bool success = false;

			XmlTextWriter SettingsXMLWriter = null;

			try
			{
				SettingsXMLWriter = new XmlTextWriter(SETTINGS_FILE, null);
				SettingsXMLWriter.WriteStartDocument();
				//SettingsXMLWriter.WriteComment("Snes360SGC Settings XML Document");

				SettingsXMLWriter.WriteStartElement("Directories");

				SettingsXMLWriter.WriteAttributeString("Temp_Directory", TEMP_DIRECTORY.ToString());

				SettingsXMLWriter.WriteEndElement();

				SettingsXMLWriter.WriteStartElement("Settings");

				SettingsXMLWriter.WriteAttributeString("auto_update", check_for_updates_auto.ToString());

				SettingsXMLWriter.WriteEndDocument();

				success = true;
			}
			catch(Exception ex)
			{
				success = false;
			}
			finally
			{
				SettingsXMLWriter.Close();
			}

			return success;
		}

		#endregion

		#region Private Functions

		static private void setDefaults()
		{
			TEMP_DIRECTORY = Path.GetTempPath();
			check_for_updates_auto = false;

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

		static public bool write()
		{
			bool success = false;

			writeSettingsFile();

			return success;
		}

		#endregion

		#endregion
	}
}
