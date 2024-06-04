using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Helpers.Messages
{
    interface MessageHelper
    {
        public string personCreate { get; set; }
        public string personCreateExist { get; set; }
        public string productCreate { get; set; }
        public string productDeleted { get; set; }
        public string productNotExistDelete { get; set; }
    }
}
