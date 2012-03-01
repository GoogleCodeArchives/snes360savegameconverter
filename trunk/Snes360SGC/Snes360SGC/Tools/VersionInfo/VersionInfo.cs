using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace Snes360SGC.Tools.VersionInfo
{
    class VersionInfo
    {
        #region Variables

        #region struct

        internal struct versionInfoStruct
        {
            # region Variables

            internal int Major { get; set; }
            internal int Minor { get; set; }
            internal int Build { get; set; }
            internal int Revision { get; set; }

            #endregion

            #region Functions

            /// <summary>
            /// Gets the version string in format of M.m.B.R
            /// </summary>
            /// <returns>version string</returns>
            internal string getFullVersion() 
            {
                return Major.ToString() + "." + Minor.ToString() + "." + Build.ToString() + "." + Revision.ToString() + ".";
            }

            #endregion
        }

        #endregion

        internal versionInfoStruct versionInfo = new versionInfoStruct();

        internal versionInfoStruct getNewestVersion()
        {
            versionInfoStruct value = new versionInfoStruct();

            //check latest version
            readVersionFile(downloadUpdateVersion());

            return value;
        }

        private versionInfoStruct readVersionFile(string location)
        {
            versionInfoStruct value = new versionInfoStruct();

            if (File.Exists(location))
            {
                try
                {
                    string line = File.ReadAllText(location);

                    string[] octets = new string[4];
                    octets = line.Split('.');

                    value.Major = int.Parse(octets[0]);
                    value.Minor = int.Parse(octets[1]);
                    value.Build = int.Parse(octets[2]);
                    value.Revision = int.Parse(octets[3]);            
                }
                catch
                {

                }
            }

            return value;
        }

        private string downloadUpdateVersion()
        {
            string tmpLocation = Path.GetTempPath() + "updateVersion.ver";

            string remoteUri = "http://snes360savegameconverter.googlecode.com/files/Version.ver";
            WebClient webClient = new WebClient();
            webClient.DownloadFile(remoteUri, tmpLocation);

            return tmpLocation;
        }

        #endregion
    }
}
