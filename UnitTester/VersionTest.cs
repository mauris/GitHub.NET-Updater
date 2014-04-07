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
        }

        [TestMethod]
        public void TestVersion2()
        {
            UpdaterVersion version = new UpdaterVersion("5.2.14665-alpha2-abc123f0");
            Assert.AreEqual(version.Major, 5);
            Assert.AreEqual(version.Minor, 2);
            Assert.AreEqual(version.Patch, 14665);
            Assert.AreEqual(version.Tag, "alpha2-abc123f0");
        }
    }
}
