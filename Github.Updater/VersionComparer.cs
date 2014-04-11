using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Github.Updater
{
    class VersionComparer: IComparer<Version>
    {
        public int Compare(Version alpha, Version bravo)
        {
            if (alpha.Major < bravo.Major)
            {
                return -1;
            }
            else if (alpha.Major > bravo.Major)
            {
                return 1;
            }
            if (alpha.Minor < bravo.Minor)
            {
                return -1;
            }
            else if (alpha.Minor > bravo.Minor)
            {
                return 1;
            }
            if (alpha.Patch < bravo.Patch)
            {
                return -1;
            }
            else if (alpha.Patch > bravo.Patch)
            {
                return 1;
            }
            return 0;
        }
    }
}
