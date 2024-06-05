using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Bll.Menu
{
    class MenuMessageBll
    {
        public void OptionMenuEs()
        {
            Console.WriteLine("1. Agregar un usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Buscar personas por nombre");
            Console.WriteLine("4. Eliminar persona");
            Console.WriteLine("5. Actualizar saldo persona");
            Console.WriteLine("6. Ingreso de producto");
            Console.WriteLine("7. Listar los productos");
            Console.WriteLine("8. Eliminar producto");
            Console.WriteLine("9. Comprar articulo");
            Console.WriteLine("10. Mostrar historial de compra");

            Console.WriteLine("20. Cambiar idioma");
            Console.WriteLine("0. Salir");
        }
        
        public void OptionMenuEn()
        {
            Console.WriteLine("1. Add user");
            Console.WriteLine("2. List uers");
            Console.WriteLine("3. Find user by name");
            Console.WriteLine("4. Delete person");
            Console.WriteLine("5. Update person");
            Console.WriteLine("6. Add product");
            Console.WriteLine("7. List product");
            Console.WriteLine("8. Delete product");
            Console.WriteLine("9. Buy product");
            Console.WriteLine("10. Show history buy");

            Console.WriteLine("20. Change language");
            Console.WriteLine("0. Exit");
        }
    }
}
