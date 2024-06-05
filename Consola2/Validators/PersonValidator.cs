using Consola2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Validators
{
    class PersonValidator
    {
        public bool IsValidCreateUser(string name, string fund, string email)
        {
            MethodsHelper methodsHelper = new MethodsHelper();
            bool dataReturn = true;

            if(!methodsHelper.ValidateNameByParams(name, 4, 25)) {
                dataReturn = false;
                Console.WriteLine("El nombre ingresado no cumple los parametros");
            }
            if(!methodsHelper.ValidateEmail(email)) {
                dataReturn = false;
                Console.WriteLine("El correo ingresado no es válido");
            }
            double fundDouble = 0;
            bool convertedFund = double.TryParse(fund, out fundDouble);
            if(convertedFund)
            {
                if (fundDouble <= 0)
                {
                    dataReturn = false;
                    Console.WriteLine("El saldo ingresado no puede ser 0 o negativo");
                }
            } else
            {
                dataReturn = false;
                Console.WriteLine("El saldo ingresado no es un valor double");
            }

            return dataReturn;
        }
    }
}
