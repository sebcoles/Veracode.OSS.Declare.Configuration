using System;
using System.Collections.Generic;
using System.Text;

namespace Veracode.OSS.Declare.Configuration.Models
{
    public class Provider
    {
        public string Name { get; set; }
        public File[] Files { get; set; }
    }
}
