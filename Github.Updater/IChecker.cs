using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Github.Updater
{
    interface IChecker
    {
        bool? Check(string repository, string currentVersion);
    }
}
