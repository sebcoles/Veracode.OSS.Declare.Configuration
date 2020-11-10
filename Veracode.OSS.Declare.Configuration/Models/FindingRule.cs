using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class FindingRule
    {
        public string type { get; set; }
        public List<string> scan_type { get; set; }
        public string value { get; set; }
    }
}
