using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class Mitigation
    {
        public string flaw_id { get; set; }
        public string cve_id { get; set; }
        public string file_name { get; set; }
        public string line_number { get; set; }
        public string link { get; set; }
        public string action { get; set; }
        public string technique { get; set; }
        public string specifics { get; set; }
        public string remaining_risk { get; set; }
        public string verification { get; set; }
        public string tsrv => $"\rTechnique : {technique}\r\nSpecifics : {specifics}\r\nRemaining Risk : {remaining_risk}\r\nVerification : {verification}";
    }
}
