using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class Provider
    {
        public string name { get; set; }
        public List<File> files { get; set; }
    }
}
