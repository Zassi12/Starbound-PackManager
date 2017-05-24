using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starbound_PackManager
{
    class Programme
    {
        private string Cmd { get; set; }
        private string Asset_Unpacker { get; set; }
        private string Asset_Packer { get; set; }
        public string Source { get; set; }
        public string Ziel { get; set; }

        public Programme(string source, string ziel)
        {
            Cmd = "Cmd.exe";
            Asset_Packer
        }
    }
}
