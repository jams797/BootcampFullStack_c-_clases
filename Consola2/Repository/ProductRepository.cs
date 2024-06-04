using Consola2.Helpers;
using Consola2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2.Repository
{
    class ProductRepository
    {

        public void CreateProduct(ProductModels model)
        {
            MethodsHelper.listProduct.Add(model);
        }

        public List<ProductModels> ListProducts()
        {
            return MethodsHelper.listProduct;
        }

        public ProductModels? FindProductById(int id)
        {
            return MethodsHelper.listProduct.FirstOrDefault(x => x.Id == id);
        }

        public bool DeleteProductById (int id)
        {
            ProductModels? modelFind = FindProductById(id);
            if(modelFind != null)
            {
                MethodsHelper.listProduct.Remove(modelFind);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
