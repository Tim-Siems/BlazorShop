using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.DataStore.HardCoded
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly IProductRepository _productRepository;

        public List<Product> productsInCart;

        public ShoppingCartRepository(IProductRepository productRepository)
        {
            productsInCart = new List<Product>();
            _productRepository = productRepository;
        }

        public void AddProduct(int id)
        {
            bool IsInCart = false;
            Product newProduct = null;

            foreach(var prod in productsInCart)
            {
                if(_productRepository.GetProduct(id) == prod)
                {
                    prod.Quantity++;
                    IsInCart = true;
                }
            }
            if(!IsInCart)
            {
                newProduct = _productRepository.GetProduct(id);
                newProduct.Quantity = 1;
                productsInCart.Add(newProduct);
            }
        }

        public IEnumerable<Product> RemoveProduct(int id)
        {
            foreach(var prod in productsInCart)
            {
                if(prod.Id == id)
                {
                    productsInCart.Remove(prod);
                    return productsInCart;
                }
            }
            return productsInCart;
        }

        public IEnumerable<Product> GetProducts()
        {
            return productsInCart;
        }
    }
}
