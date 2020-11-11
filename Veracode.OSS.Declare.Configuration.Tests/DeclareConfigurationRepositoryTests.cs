using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Tests
{
    [TestFixture]
    public class DeclareConfigurationRepositoryTests
    {
        public string complete_configuration_file = "complete.json";
        [Test]
        public void AppsParsesConfigurationCorrectly()
        {
            var repo = new DeclareConfigurationRepository(complete_configuration_file);
            var apps = repo.Apps();
            Assert.IsTrue(apps.Count == 1);
        }
    }
}
