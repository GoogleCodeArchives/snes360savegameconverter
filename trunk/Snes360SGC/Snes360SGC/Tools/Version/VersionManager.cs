using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using Snes360SGC.Tools.Settings;
//using Snes360SGC.Tools.VersionInfo;

namespace Snes360SGC.Tools.VersionManager
{
    class VersionManager
    {
        //string Temp_Path = Settings.Settings
        string PATH_TO_LOCAL_VERSION = Environment.CurrentDirectory.ToString() + "\\Version.ver";
        private VersionInfo.versionInfoStruct _InstalledVersionInfo = new VersionInfo.versionInfoStruct();
        private VersionInfo.versionInfoStruct _LatestVersionInfo = new VersionInfo.versionInfoStruct();

        internal VersionInfo.versionInfoStruct getInstalledVersionInfo() { return this._InstalledVersionInfo; }
        internal VersionInfo.versionInfoStruct getLatestVersionInfo() { return this._LatestVersionInfo; }

        public VersionManager()
        {
            //Init();
            getCurrentVersion();
        }

        #region Functions

        /// <summary>
        /// Gets the latest version identifier file
        /// </summary>
        /// <returns>The Version Structure</returns>
        internal VersionInfo.versionInfoStruct getNewestVersion(string tempPath)
        {
            return readVersionFile(downloadFile(tempPath, downloadFileType.version));
        }

        internal string getInstalledFullVersionString()
        {
            return this._InstalledVersionInfo.getFullVersion();
        }

        internal string getChangeLog(string tempPath)
        {
            string path = downloadFile(tempPath, downloadFileType.changeLog);
            string result = "";

            if (File.Exists(path))
            {
                result = path;
            }

            return result;
        }

        /// <summary>
        /// Reads a version file
        /// </summary>
        /// <param name="location">Path to version file to read</param>
        /// <returns>The Version Stucture</returns>
        private VersionInfo.versionInfoStruct readVersionFile(string location)
        {
            VersionInfo.versionInfoStruct value = new VersionInfo.versionInfoStruct();

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
        private string downloadFile(string tempPath, downloadFileType fileType)
        {
            string remoteUri = StringEnum.GetStringValue(fileType);
            string tmpLocation = tempPath + "\\" + Path.GetFileName(remoteUri);

            
            WebClient webClient = new WebClient();
            webClient.DownloadFile(remoteUri, tmpLocation);

            return tmpLocation;
        }

        /// <summary>
        /// Gets the current running version
        /// </summary>
        /// <returns>The version Stucture</returns>
        internal VersionInfo.versionInfoStruct getCurrentVersion()
        {
            VersionInfo.versionInfoStruct value = new VersionInfo.versionInfoStruct();

            if (File.Exists(PATH_TO_LOCAL_VERSION))
                value = readVersionFile(PATH_TO_LOCAL_VERSION);

            return value;
        }

        internal bool checkIfNewer(VersionInfo.versionInfoStruct installedVersion, VersionInfo.versionInfoStruct LatestVersion)
        {
            return compareVersions(installedVersion, LatestVersion);
        }

        private bool compareVersions(VersionInfo.versionInfoStruct InstalledVersion, VersionInfo.versionInfoStruct LatestVersion)
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

        internal string downloadUpdate(string tempPath)
        {
            string value = "";

            string path = downloadFile(tempPath, downloadFileType.newestUpdate);

            if (File.Exists(path))
            {
                value = path;
            }

            return value;
        }

        #endregion

    }
}
