using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Helpers.Messages
{
    class es_MessageHelper : MessageHelper
    {
        public string personCreate { get; set; } = "Persona agregada correctamente";
        public string personCreateExist { get; set; } = "La persona ya esta registrada, intente con otro usuario";
        public string productCreate { get; set; }  = "Se creo el producto";
        public string productDeleted { get; set; } = "Se elimino el producto con exito";
        public string productNotExistDelete { get; set; } = "El producto a eliminar no existe";
    }
}
