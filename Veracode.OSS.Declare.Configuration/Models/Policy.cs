using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class Policy
    {
        public string name { get; set; }
        public int sca_blacklist_grace_period { get; set; }

        public List<CustomSeverity> custom_severities { get; set; }
        public List<FindingRule> finding_rules { get; set; }
        public List<ScanFrequencyRule> scan_frequency_rules { get; set; }
        public int sev0_grace_period { get; set; }
        public int sev1_grace_period { get; set; }
        public int sev2_grace_period { get; set; }
        public int sev3_grace_period { get; set; }
        public int sev4_grace_period { get; set; }
        public int sev5_grace_period { get; set; }
        public string description { get; set; }
        public int score_grace_period { get; set; }
    }
}
