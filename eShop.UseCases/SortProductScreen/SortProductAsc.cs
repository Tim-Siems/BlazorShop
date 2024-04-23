using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SortProductScreen
{
    public class SortProductAsc : ISortProductAsc
    {
        private IProductRepository productRepository;

        public SortProductAsc(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return productRepository.SortProductsAsc();
        }
    }
}
