using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShop.UseCases.SortProductScreen
{
    public class SortProductDesc : ISortProductDesc
    {
        private IProductRepository productRepository;

        public SortProductDesc(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return productRepository.SortProductsDesc();
        }
    }
}
