using clase1.Helpers;
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
    }
}
