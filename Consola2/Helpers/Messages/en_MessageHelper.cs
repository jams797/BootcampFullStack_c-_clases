using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Helpers.Messages
{
    class en_MessageHelper : MessageHelper
    {
        public string personCreate { get; set; } = "Person created Success";
        public string personCreateExist { get; set; } = "This person exist";
        public string productCreate { get; set; }  = "Product created success";
        public string productDeleted { get; set; } = "Deleted product success";
        public string productNotExistDelete { get; set; } = "This product not exist";
    }
}
