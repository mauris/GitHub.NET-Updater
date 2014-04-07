using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UpdaterVersion = Github.Updater.Version;

namespace UnitTester
{
    [TestClass]
    public class VersionTest
    {
        [TestMethod]
        public void TestVersion1()
        {
            UpdaterVersion version = new UpdaterVersion("1.0.5-beta");
            Assert.AreEqual(version.Major, 1);
            Assert.AreEqual(version.Minor, 0);
            Assert.AreEqual(version.Patch, 5);
            Assert.AreEqual(version.Tag, "beta");
            Assert.AreEqual(version.Hash, "");
        }
    }
}
