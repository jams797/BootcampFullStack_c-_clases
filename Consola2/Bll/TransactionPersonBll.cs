using clase1.Helpers;
using Consola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Bll
{
    class TransactionPersonBll
    {
        public void AddPerson()
        {
            Console.WriteLine("Ingrese el nonbre de la persona");
            string namePerson = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese el saldo de la persona");
            string fundPerson = Console.ReadLine().Trim();

            PersonModels personS = SearchPersonByName(namePerson);

            if (personS == null)
            {

                PersonModels? personLast = MethodsHelper.listPerson.LastOrDefault();
                int idSec = personLast == null ? 1 : personLast.Id + 1;

                MethodsHelper.listPerson.Add(
                    new PersonModels
                    {
                        Name = namePerson,
                        Id = idSec,
                        Fund = double.Parse(fundPerson),
                    }
                );
                Console.WriteLine("Persona agregada correctamente");
            } else
            {
                Console.WriteLine("La persona ya existe");
            }
        }

        public void Menu()
        {
            Console.WriteLine("----- MENU -----");
            Console.WriteLine("1. Agregar un usuario");
            Console.WriteLine("5. Salir");

            int opcion = int.Parse(Console.ReadLine());

            if( opcion == 5 ) {
                return;
            }

            switch ( opcion )
            {
                case 1:
                    AddPerson();
                    break;
            }


            Menu();
        }

        PersonModels? SearchPersonByName( string name )
        {
            PersonModels? person = MethodsHelper.listPerson.FirstOrDefault(x => x.Name == name);
            return person;
        }
    }
}
