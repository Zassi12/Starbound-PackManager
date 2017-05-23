using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Starbound_PackManager
{
    class Global
    {
        public string App_Path = System.Reflection.Assembly.GetExecutingAssembly().Location;
        public string Steam_Asset_Packer = @"";
        public string Steam_Asset_Unpacker = @"";
        public string FileSource = @"";
        public string FileDestinaton = @"";
        public string TempPath = @"";
    }
}
