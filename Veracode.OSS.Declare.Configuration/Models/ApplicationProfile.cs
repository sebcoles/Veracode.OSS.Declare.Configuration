using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class ApplicationProfile
    {
        public string id { get; set; }
        public string policy_schedule { get; set; }
        public string application_name { get; set; }
        public string criticality { get; set; }
        public string business_owner { get; set; }
        public string business_owner_email { get; set; }
        public List<File> files { get; set; }
        public List<Module> modules { get; set; }
        public Policy policy { get; set; }
        public List<User> users { get; set; }
        public List<Mitigation> mitigations { get; set; }
        public List<Sandbox> sandboxes { get; set; }
    }
}
