using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class Module
    {
        public Module()
        {
            messages = new List<string>();
        }
        public string module_id { get; set; }
        public string module_name { get; set; }
        public bool can_be_entry_point { get; set; }
        public bool entry_point { get; set; }
        public List<string> messages { get; set; }
    }

}
