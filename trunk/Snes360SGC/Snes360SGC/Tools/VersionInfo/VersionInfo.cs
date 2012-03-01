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
                return Major.ToString() + "." + Minor.ToString() + "." + Build.ToString() + "." + Revision.ToString();
            }

            #endregion
        }

        #endregion

        string PATH_TO_LOCAL_VERSION = Environment.CurrentDirectory.ToString() + "\\Version.ver";

        internal versionInfoStruct versionInfo = new versionInfoStruct();

        #endregion

        #region Functions

        /// <summary>
        /// Gets the latest version identifier file
        /// </summary>
        /// <returns>The Version Structure</returns>
        internal versionInfoStruct getNewestVersion()
        {
            return readVersionFile(downloadUpdateVersion());
        }

        /// <summary>
        /// Reads a version file
        /// </summary>
        /// <param name="location">Path to version file to read</param>
        /// <returns>The Version Stucture</returns>
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

        /// <summary>
        /// Downloads the latest version identifier file
        /// </summary>
        /// <returns>the temp path of the downloaded version file to be read</returns>
        private string downloadUpdateVersion()
        {
            string tmpLocation = Path.GetTempPath() + "updateVersion.ver";

            string remoteUri = "http://snes360savegameconverter.googlecode.com/files/Version.ver";
            WebClient webClient = new WebClient();
            webClient.DownloadFile(remoteUri, tmpLocation);

            return tmpLocation;
        }

        /// <summary>
        /// Gets the current running version
        /// </summary>
        /// <returns>The version Stucture</returns>
        internal versionInfoStruct getCurrentVersion()
        {
            versionInfoStruct value = new versionInfoStruct();

            if (File.Exists(PATH_TO_LOCAL_VERSION))
                value = readVersionFile(PATH_TO_LOCAL_VERSION);

            return value;
        }

        internal bool checkIfNewer(versionInfoStruct installedVersion, versionInfoStruct LatestVersion)
        {
            return compareVersions(installedVersion, LatestVersion);
        }

        private bool compareVersions(versionInfoStruct InstalledVersion, versionInfoStruct LatestVersion)
        {
            bool result = false;

            try
            {
                if (LatestVersion.Major > InstalledVersion.Major)
                {
                    result = true;
                }
                else if (LatestVersion.Minor > InstalledVersion.Minor)
                {
                    result = true;
                }
                else if (LatestVersion.Build > InstalledVersion.Build)
                {
                    result = true;
                }
                else if (LatestVersion.Revision > InstalledVersion.Revision)
                {
                    result = true;
                }
            }
            catch
            {
                result = false;
            }

            return result;
        }

        #endregion
    }
}
