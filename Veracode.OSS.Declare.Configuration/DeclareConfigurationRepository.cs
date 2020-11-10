using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Veracode.OSS.Declare.Configuration.Models;

namespace Veracode.OSS.Declare.Configuration
{
    public interface IDeclareConfigurationRepository
    {
        List<ApplicationProfile> Apps();
    }

    public class DeclareConfigurationRepository : IDeclareConfigurationRepository
    {
        private List<ApplicationProfile> _apps;

        public DeclareConfigurationRepository(string filePath)
        {
            DeclareConfiguration config;
            using (StreamReader r = new StreamReader(filePath))
            {
                string json = r.ReadToEnd();
                config = JsonConvert.DeserializeObject<DeclareConfiguration>(json);
            }
            _apps = config.application_profiles;
        }
        public List<ApplicationProfile> Apps()
        {
            return _apps;
        }
    }
}
