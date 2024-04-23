using eShop.CoreBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.PluginInterfaces.DataStore
{
    public interface IShoppingCartRepository
    {
        public void AddProduct(int id);

        public IEnumerable<Product> RemoveProduct(int id);

        public IEnumerable<Product> GetProducts();

    }
}
