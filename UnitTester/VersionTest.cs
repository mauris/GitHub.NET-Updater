using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpdaterVersion = Github.Updater.Version;

namespace UnitTester
{
    [TestClass]
    public class VersionTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            UpdaterVersion version = new UpdaterVersion("1.0.0");
        }
    }
}
