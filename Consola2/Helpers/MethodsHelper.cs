using Consola2.Helpers;
using Consola2.Helpers.Messages;
using Consola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Helpers
{
    class MethodsHelper
    {

        static public string codeLanguage = "es";

        static public List<BuyHistoryModel> historyBuy = new List<BuyHistoryModel>();

        static public List<PersonModels> listPerson = new List<PersonModels>
        {
            new PersonModels
            {
                Id = 1,
                Name = "Jose",
                Fund = 200.2,
            },
            new PersonModels
            {
                Id = 2,
                Name = "Pepe",
                Fund = 300.8,
            },
        };
        static public List<ProductModels> listProduct = new List<ProductModels>()
        {
            new ProductModels
            {
                Id= 1,
                Name = "Chocolate",
                Count = 12,
                Price = 10.5,
            },
            new ProductModels
            {
                Id= 2,
                Name = "Silla",
                Count = 14,
                Price = 87.5,
            },
        };


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

        public void ShowDataProduct(ProductModels prod)
        {
            Console.WriteLine($"{prod.Id} - {prod.Name} hay {prod.Count} en stock por valor unitario de {prod.Price}");
        }

        public void ShowDataProducts(List<ProductModels> products)
        {
            foreach (ProductModels prod in products)
            {
                ShowDataProduct(prod);
            }
        }


        static public MessageHelper Message ()
        {

            switch(codeLanguage)
            {
                case "es":
                    return new es_MessageHelper();
                case "en":
                    return new en_MessageHelper();
            }

            return null;
        }
    }
}
