using Consola2.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Bll.Menu
{
    class MenuBll
    {

        TransactionPersonBll transPerBll = new TransactionPersonBll();
        ProductBll prdBll = new ProductBll();
        BuyBll buyBll = new BuyBll();

        public void Menu()
        {

            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("****************************************");
            Console.WriteLine("----- MENU -----");
            
            MenuMessageBll menuMessageBll = new MenuMessageBll();
            switch(MethodsHelper.codeLanguage) {
                case "es":
                    menuMessageBll.OptionMenuEs();
                    break;
                case "en":
                    menuMessageBll.OptionMenuEn();
                    break;
            }

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
                case 9:
                    buyBll.BuyProduct();
                    break;
                case 10:
                    buyBll.ShowAllHistory();
                    break;
                case 20:
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

            switch (opcion)
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
