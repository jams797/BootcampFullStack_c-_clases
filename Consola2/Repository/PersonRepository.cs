using Consola2.Helpers;
using Consola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Repository
{
    class PersonRepository
    {
        public PersonModels? SearchPersonByName(string name)
        {
            PersonModels? person = MethodsHelper.listPerson.FirstOrDefault(x => x.Name == name);
            return person;
        }

        public List<PersonModels> SearchPersonsByNameConstain(string name)
        {
            List<PersonModels> persons = MethodsHelper.listPerson.Where(x => x.Name.Contains(name)).ToList();
            return persons;
        }

        public bool SavePerson(PersonModels person)
        {
            MethodsHelper.listPerson.Add(person);
            return true;
        }

        public PersonModels? SearchPersonById(int idPerson)
        {
            return MethodsHelper.listPerson.FirstOrDefault((x) => x.Id == idPerson);
        }

        public bool DelePersonById(int idPerson)
        {
            PersonModels? personSearch = SearchPersonById(idPerson);
            if (personSearch != null)
            {
                MethodsHelper.listPerson.Remove(personSearch);
                return true;
            } else
            {
                return false;
            }
        }
        
        public bool UpdateFundPerson(int idPerson, double fund)
        {
            PersonModels? personSearch = SearchPersonById(idPerson);
            if (personSearch != null)
            {
                personSearch.Fund = fund;
                
                return true;
            } else
            {
                return false;
            }
        }

        public void ReduceFundPerson(int idPerson, double fundReduce)
        {
            PersonModels? personM = MethodsHelper.listPerson.FirstOrDefault(x => x.Id == idPerson);
            personM.Fund = personM.Fund - fundReduce;
        }
    }
}
