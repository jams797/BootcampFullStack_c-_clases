using Consola2.Helpers;
using Consola2.Models;
using Consola2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Bll
{
    class BuyBll
    {

        public void ShowAllHistory()
        {
            List<BuyHistoryModel> listHistory = (new BuyHistoryRepository()).GetAllHistory();

            foreach (BuyHistoryModel model in listHistory)
            {
                ProductModels? productModels = (new ProductRepository()).FindProductById(model.idProduct);
                PersonModels? personModels = (new PersonRepository()).SearchPersonById(model.idPerson);
                Console.WriteLine($"{model.id} - Producto {productModels.Name} se vendio {model.countP} unidades a la persona {personModels.Name}");
            }
        }

        public void BuyProduct()
        {
            Console.WriteLine("Ingrese el ID del producto a comprar");
            int idProd = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad a comprar");
            int countP = int.Parse(Console.ReadLine());

            ProductRepository productRepository = new ProductRepository();
            ProductModels? prodM = productRepository.FindProductById(idProd);

            if(prodM == null)
            {
                Console.WriteLine("Producto no existe");
                return;
            }
            if(prodM.Count < countP)
            {
                Console.WriteLine("La cantidad ingresada exede lo permitido");
                return;
            }

            Console.WriteLine("Ingrese el ID de la persona");
            int idPerson = int.Parse(Console.ReadLine());

            PersonRepository personRepository = new PersonRepository();
            PersonModels? personM = personRepository.SearchPersonById(idPerson);

            if (personM == null)
            {
                Console.WriteLine("Persona no existe");
                return;
            }
            double valueTotal = prodM.Price * countP;
            if (personM.Fund < valueTotal)
            {
                Console.WriteLine("El stock no cubre los productos");
                return;
            }


            productRepository.ReduceStockProduct(idProd, countP);

            personRepository.ReduceFundPerson(idProd, valueTotal);

            (new BuyHistoryRepository()).RegisterBuyHistory(idProd, idPerson, countP);

            Console.WriteLine("Producto vendido correctamente");
        }
    }
}
