using Consola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase1.Helpers
{
    class MethodsHelper
    {

        static public List<PersonModels> listPerson = new List<PersonModels>();
        static public List<ProductModels> listProduct = new List<ProductModels>();


        public void ShowDataPerson(PersonModels person)
        {
            Console.WriteLine($"{person.Id} - {person.Name} tiene {person.Fund} de saldo");
        }

        public void ShowDataPersons(List<PersonModels> persons)
        {
            foreach (PersonModels person in persons)
            {
                ShowDataPerson(person);
            }
        }
    }
}
