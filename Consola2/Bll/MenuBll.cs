using Consola2.Helpers;
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
        ProductBll prdBll = new ProductBll();

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
            Console.WriteLine("6. Ingreso de producto");
            Console.WriteLine("7. Listar los productos");
            Console.WriteLine("8. Eliminar producto");

            Console.WriteLine("10. Cambiar idioma");
            Console.WriteLine("0. Salir");

            string? opcionString = Console.ReadLine();
            string opcionT = opcionString == null ? "0" : opcionString;
            int opcion = int.Parse(opcionT);

            if (opcion == 0)
            {
                return;
            }

            Console.Clear();

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
                case 6:
                    prdBll.InsertProduct();
                    break;
                case 7:
                    prdBll.ListProducts();
                    break;
                case 8:
                    prdBll.DeleteProd();
                    break;
                case 10:
                    ChangeLanguage();
                    break;
            }

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Presione un tecla para continuar...");
            Console.ReadKey();
            Console.Clear();


            Menu();
        }

        void ChangeLanguage()
        {
            Console.WriteLine("****************************************");
            Console.WriteLine("----- Seleccione el idioma -----");
            Console.WriteLine("1. Español");
            Console.WriteLine("2. Ingles");
            Console.WriteLine("****************************************");

            int opcion = int.Parse(Console.ReadLine());

            switch(opcion)
            {
                case 1:
                    MethodsHelper.codeLanguage = "es";
                    Console.WriteLine("Idioma cambiado a español");
                    break;
                case 2:
                    MethodsHelper.codeLanguage = "en";
                    Console.WriteLine("Idioma cambiado a ingles");
                    break;
            }
        }
    }
}
