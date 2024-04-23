using eShop.CoreBusiness.Models;
using eShop.UseCases.PluginInterfaces.DataStore;

namespace eShop.DataStore.HardCoded
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> products;

        public ProductRepository()
        {
            products = new List<Product>
            {
                new Product { Id = 1, Brand = "Tims Trees", Name = "Eiche", Price = 149.99, ImageLink = "Eiche.jpg", Description = "High Quality Tree", Quantity = 0 },
                new Product { Id = 2, Brand = "Tims Trees", Name = "Olivenbaum", Price = 99.99, ImageLink = "Olivenbaum.jpg", Description = "High Quality Tree", Quantity = 0  },
                new Product { Id = 3, Brand = "Tims Trees", Name = "Fichte", Price = 120.99, ImageLink = "Fichte.jpg", Description = "High Quality Tree", Quantity = 0  },
                new Product { Id = 4, Brand = "Tims Trees", Name = "Birke", Price = 99.99, ImageLink = "Birke.jpg", Description = "High Quality Tree", Quantity = 0  },
                new Product { Id = 5, Brand = "Tims Trees", Name = "Buche", Price = 159.99, ImageLink = "Buche.png", Description = "High Quality Tree", Quantity = 0 },
            };
        }

        public Product GetProduct(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Product> GetProducts(string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                return products;
            }
            return products.Where(x => x.Name.ToLower().Contains(filter.ToLower()));
        }

        public IEnumerable<Product> SortProductsDesc()
        {
                return products.OrderByDescending(x => x.Price);
        }

        public IEnumerable<Product> SortProductsAsc()
        {
            return products.OrderBy(x => x.Price);
        }
    }
}