using Consola2.Helpers;
using Consola2.Helpers.Messages;
using Consola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                Email = "correo1@gmail.com",
            },
            new PersonModels
            {
                Id = 2,
                Name = "Pepe",
                Fund = 300.8,
                Email = "correo1@gmail.com",
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
            Console.WriteLine($"{person.Id} - {person.Name} tiene {person.Fund} de saldo, con correo {person.Email}");
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

        public bool ValidateNameByParams(string name, int lengthMin, int lengthMax)
        {
            if (!Regex.IsMatch(name, (new ExpressValidateVarsHelper()).expressNameVal))
            {
                return false;
            } else
            {
                return true;
            }
            if (name.Length >= lengthMin && name.Length <= lengthMax)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ValidateEmail(string email)
        {
            if(!Regex.IsMatch(email, (new ExpressValidateVarsHelper()).expressEmailVal)) {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
