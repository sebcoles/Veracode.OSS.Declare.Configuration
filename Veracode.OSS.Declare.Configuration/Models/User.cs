using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class User
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email_address { get; set; }
        public string roles { get; set; }
        public string teams { get; set; }
    }

}
