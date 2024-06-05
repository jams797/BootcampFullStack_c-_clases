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
    class ProductBll
    {

        ProductRepository productRepository = new ProductRepository();
        public void InsertProduct()
        {
            Console.WriteLine("Ingrese el nombre del producto");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese el stock del producto");
            int countP = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el precio del producto");
            double price = double.Parse(Console.ReadLine());

            ProductModels lastP = MethodsHelper.listProduct.LastOrDefault();
            int idP = lastP == null ? 1 : lastP.Id + 1;

            ProductModels prod = new ProductModels
            {
                Id = idP,
                Name = name,
                Count = countP,
                Price = price,
            };

            productRepository.CreateProduct(prod);

            Console.WriteLine(MethodsHelper.Message().productCreate);
        }


        public void ListProducts()
        {
            Console.WriteLine("Los productos son");
            List<ProductModels> products = productRepository.ListProducts();
            (new MethodsHelper()).ShowDataProducts(products);
        }

        public void DeleteProd()
        {
            Console.WriteLine("Ingrese el id del producto a eliminar");
            int id = int.Parse(Console.ReadLine());

            bool haveHistry = (new BuyHistoryRepository()).HaveHistoryByProduct(id);
            if (haveHistry)
            {
                Console.WriteLine("No se puede eliminar el producto, ya que tiene una factura activa");
                return;
            }

            bool deleted = productRepository.DeleteProductById(id);

            if (deleted)
            {
                Console.WriteLine(MethodsHelper.Message().productDeleted);
            } else
            {
                Console.WriteLine(MethodsHelper.Message().productNotExistDelete);
            }
        }
    }
}
