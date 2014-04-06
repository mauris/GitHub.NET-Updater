using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Github.Updater
{
    public class Version
    {
        public int Major { get; set; }

        public int Minor { get; set; }

        public int Patch { get; set; }

        public int Build { get; set; }

        public string Tag { get; set; }

        public Version(string version)
        {
            Match match = Regex.Match(version, @"^([0-9]+)\.([0-9]+)\.([0-9]+)(?:-([0-9A-Za-z-]+(?:\.[0-9A-Za-z-]+)*))?(?:\\+[0-9A-Za-z-]+)?$");
            
        }
    }
}
