using Consola2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Validators
{
    class ProductValidator
    {
        public bool IsValidCreateProduct(string name, int countP, double price)
        {
            MethodsHelper methodsHelper = new MethodsHelper();
            bool dataReturn = true;

            if (!methodsHelper.ValidateNameByParams(name, 5, 50))
            {
                dataReturn = false;
                Console.WriteLine("El nombre ingresado no cumple los parametros");
            }
            if (countP <= 0)
            {
                dataReturn = false;
                Console.WriteLine("La cantidad ingresada no puede ser 0 o negativo");
            }
            if (price <= 0)
            {
                dataReturn = false;
                Console.WriteLine("El precio ingresado no puede ser 0 o negativo");
            }

            return dataReturn;
        }
    }
}
