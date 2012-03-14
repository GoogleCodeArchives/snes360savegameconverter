using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;
using System.Reflection;

namespace Snes360SGC.Tools
{
    internal enum downloadFileType
    {
        [StringValue("http://snes360savegameconverter.googlecode.com/files/Version.ver")]
        version = 1,
        [StringValue("http://snes360savegameconverter.googlecode.com/files/ChangeLog.txt")]
        changeLog = 2,
        [StringValue("http://snes360savegameconverter.googlecode.com/files/Snes360v[version].zip")]
        newestUpdate = 3
    }

    internal class StringValue : System.Attribute
    {
        private string _value;

        public StringValue(string value)
        {
            _value = value;
        }

        public string Value
        {
            get { return _value; }
        }
    }

    internal static class StringEnum
    {
        public static string GetStringValue(Enum value)
        {
            string output = null;
            Type type = value.GetType();

            //Check first in our cached results...

            //Look for our 'StringValueAttribute' 

            //in the field's custom attributes

            FieldInfo fi = type.GetField(value.ToString());
            StringValue[] attrs =
               fi.GetCustomAttributes(typeof(StringValue),
                                       false) as StringValue[];
            if (attrs.Length > 0)
            {
                output = attrs[0].Value;
            }

            return output;
        }
    }

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

        //string PATH_TO_LOCAL_VERSION = Environment.CurrentDirectory.ToString() + "\\Version.ver";

        internal versionInfoStruct versionInfo = new versionInfoStruct();

        #endregion

        //#region Functions

        ///// <summary>
        ///// Gets the latest version identifier file
        ///// </summary>
        ///// <returns>The Version Structure</returns>
        //internal versionInfoStruct getNewestVersion(string tempPath)
        //{
        //    return readVersionFile(downloadFile(tempPath, downloadFileType.version));
        //}

        //internal string getChangeLog(string tempPath)
        //{
        //    string path = downloadFile(tempPath, downloadFileType.changeLog);
        //    string result = "";

        //    if (File.Exists(path))
        //    {
        //        result = path;
        //    }

        //    return result;
        //}

        ///// <summary>
        ///// Reads a version file
        ///// </summary>
        ///// <param name="location">Path to version file to read</param>
        ///// <returns>The Version Stucture</returns>
        //private versionInfoStruct readVersionFile(string location)
        //{
        //    versionInfoStruct value = new versionInfoStruct();

        //    if (File.Exists(location))
        //    {
        //        try
        //        {
        //            string line = File.ReadAllText(location);

        //            string[] octets = new string[4];
        //            octets = line.Split('.');

        //            value.Major = int.Parse(octets[0]);
        //            value.Minor = int.Parse(octets[1]);
        //            value.Build = int.Parse(octets[2]);
        //            value.Revision = int.Parse(octets[3]);            
        //        }
        //        catch
        //        {

        //        }
        //    }

        //    return value;
        //}

        ///// <summary>
        ///// Downloads the latest version identifier file
        ///// </summary>
        ///// <returns>the temp path of the downloaded version file to be read</returns>
        //private string downloadFile(string tempPath, downloadFileType fileType)
        //{
        //    string remoteUri = StringEnum.GetStringValue(fileType);
        //    string tmpLocation = tempPath + "\\" + Path.GetFileName(remoteUri);

            
        //    WebClient webClient = new WebClient();
        //    webClient.DownloadFile(remoteUri, tmpLocation);

        //    return tmpLocation;
        //}

        ///// <summary>
        ///// Gets the current running version
        ///// </summary>
        ///// <returns>The version Stucture</returns>
        //internal versionInfoStruct getCurrentVersion()
        //{
        //    versionInfoStruct value = new versionInfoStruct();

        //    if (File.Exists(PATH_TO_LOCAL_VERSION))
        //        value = readVersionFile(PATH_TO_LOCAL_VERSION);

        //    return value;
        //}

        //internal bool checkIfNewer(versionInfoStruct installedVersion, versionInfoStruct LatestVersion)
        //{
        //    return compareVersions(installedVersion, LatestVersion);
        //}

        //private bool compareVersions(versionInfoStruct InstalledVersion, versionInfoStruct LatestVersion)
        //{
        //    bool result = false;

        //    try
        //    {
        //        if (LatestVersion.Major > InstalledVersion.Major)
        //        {
        //            result = true;
        //        }
        //        else if (LatestVersion.Minor > InstalledVersion.Minor)
        //        {
        //            result = true;
        //        }
        //        else if (LatestVersion.Build > InstalledVersion.Build)
        //        {
        //            result = true;
        //        }
        //        else if (LatestVersion.Revision > InstalledVersion.Revision)
        //        {
        //            result = true;
        //        }
        //    }
        //    catch
        //    {
        //        result = false;
        //    }

        //    return result;
        //}

        //internal string downloadUpdate(string tempPath)
        //{
        //    string value = "";

        //    string path = downloadFile(tempPath, downloadFileType.newestUpdate);

        //    if (File.Exists(path))
        //    {
        //        value = path;
        //    }

        //    return value;
        //}

        //#endregion
    }
}
