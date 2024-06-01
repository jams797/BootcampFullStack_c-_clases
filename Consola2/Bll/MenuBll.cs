using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Bll
{
    class MenuBll
    {

        TransactionPersonBll transPerBll = new TransactionPersonBll();

        public void Menu()
        {

            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Agregar un usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Buscar personas por nombre");
            Console.WriteLine("4. Eliminar persona");
            Console.WriteLine("5. Actualizar saldo persona");
            Console.WriteLine("0. Salir");

            string? opcionString = Console.ReadLine();
            string opcionT = opcionString == null ? "0" : opcionString;
            int opcion = int.Parse(opcionT);

            if (opcion == 0)
            {
                return;
            }

            switch (opcion)
            {
                case 1:
                    transPerBll.AddPerson();
                    break;
                case 2:
                    transPerBll.ListPersons();
                    break;
                case 3:
                    transPerBll.ListPersonsByName();
                    break;
                case 4:
                    transPerBll.DeletePerson();
                    break;
                case 5:
                    transPerBll.UpdateFundPerson();
                    break;
            }


            Menu();
        }
    }
}
