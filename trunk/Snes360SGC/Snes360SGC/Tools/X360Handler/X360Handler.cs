using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace Snes360SGC.Tools.X360Handler
{
    class X360Handler
    {
        string PATH_TO_FILE = "";

        


        public X360Handler(string pathToFile)
        {
            PATH_TO_FILE = pathToFile;
        }

        public bool checkIsValidFile()
        {
            bool result = false;

            if(File.Exists(PATH_TO_FILE))
            {

            }

            return false;
        }

    }
}
