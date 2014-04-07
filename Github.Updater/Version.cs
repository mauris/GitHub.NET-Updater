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

        public string Hash { get; set; }

        public Version(string version)
        {
            Match match = Regex.Match(version, @"^([0-9]+)\.([0-9]+)\.([0-9]+)(?:-([0-9A-Za-z-]+(?:\.[0-9A-Za-z-]+)*))?(?:\\+[0-9A-Za-z-]+)?$");
            if (match.Success && match.Groups.Count == 5)
            {
                Major = Convert.ToInt32(match.Groups[1].Value);
                Minor = Convert.ToInt32(match.Groups[2].Value);
                Patch = Convert.ToInt32(match.Groups[3].Value);
                Tag = match.Groups[4].Value;
                Hash = match.Groups[5].Value;
            }
            else
            {
                throw new InvalidOperationException("Version number supplied - \"" + version + "\" - is invalid");
            }
        }
    }
}
