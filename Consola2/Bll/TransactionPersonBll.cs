using Consola2.Helpers;
using Consola2.Helpers.Messages;
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

            PersonModels? personS = personRepository.SearchPersonByName(namePerson);

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
                Console.WriteLine(MethodsHelper.Message().personCreate);
            } else
            {
                Console.WriteLine(MethodsHelper.Message().personCreateExist);
            }
        }

        public void ListPersons()
        {
            (new MethodsHelper()).ShowDataPersons(MethodsHelper.listPerson);
        }

        public void ListPersonsByName()
        {
            Console.WriteLine("Ingrese el nombre o las letras del usuario a buscar");
            string nameSearch = Console.ReadLine().Trim();

            List<PersonModels> persons = (new PersonRepository()).SearchPersonsByNameConstain(nameSearch);
            (new MethodsHelper()).ShowDataPersons(persons);
        }
        
        public void DeletePerson()
        {
            Console.WriteLine("Ingrese el ID a eliminar");
            int idPerson = int.Parse(Console.ReadLine().Trim());

            bool haveHistry = (new BuyHistoryRepository()).HaveHistoryByPerson(idPerson);
            if( haveHistry ) {
                Console.WriteLine("No se puede eliminar el usuario, ya que tiene una factura activa");
                return;
            }

            bool deleted = (new PersonRepository()).DelePersonById(idPerson);
            if (deleted)
            {
                Console.WriteLine("Persona eliminada correcamente");
            } else
            {
                Console.WriteLine("La persona a eliminar no existe");
            }
        }
        
        public void UpdateFundPerson()
        {
            Console.WriteLine("Ingrese el ID a actualizar");
            int idPerson = int.Parse(Console.ReadLine().Trim());
            
            Console.WriteLine("Ingrese el nuevo saldo");
            double fund = double.Parse(Console.ReadLine().Trim());

            bool updated = (new PersonRepository()).UpdateFundPerson(idPerson, fund);
            if (updated)
            {
                Console.WriteLine("Persona actualizada correcamente");
            } else
            {
                Console.WriteLine("La persona a eliminar no existe");
            }
        }
    }
}
