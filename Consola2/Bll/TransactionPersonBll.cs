using clase1.Helpers;
using Consola2.Models;
using Consola2.Repository;
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
            PersonRepository personRepository = new PersonRepository();
            Console.WriteLine("Ingrese el nonbre de la persona");
            string namePerson = Console.ReadLine().Trim();
            Console.WriteLine("Ingrese el saldo de la persona");
            string fundPerson = Console.ReadLine().Trim();

            PersonModels personS = personRepository.SearchPersonByName(namePerson);

            if (personS == null)
            {

                PersonModels? personLast = MethodsHelper.listPerson.LastOrDefault();
                int idSec = personLast == null ? 1 : personLast.Id + 1;

                personRepository.SavePerson(
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

        void ListPersons()
        {
            (new MethodsHelper()).ShowDataPersons(MethodsHelper.listPerson);
        }

        void ListPersonsByName()
        {
            Console.WriteLine("Ingrese el nombre o las letras del usuario a buscar");
            string nameSearch = Console.ReadLine().Trim();

            List<PersonModels> persons = (new PersonRepository()).SearchPersonsByNameConstain(nameSearch);
            (new MethodsHelper()).ShowDataPersons(persons);
        }

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
            Console.WriteLine("5. Salir");

            string opcionString = Console.ReadLine();
            int opcion = int.Parse(opcionString);

            if( opcion == 5 ) {
                return;
            }

            switch ( opcion )
            {
                case 1:
                    AddPerson();
                    break;
                case 2:
                    ListPersons();
                    break;
                case 3:
                    ListPersonsByName();
                    break;
            }


            Menu();
        }
    }
}
