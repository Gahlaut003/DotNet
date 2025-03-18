using Utility_001.Data;

namespace Utility_001.Repository
{
    public class ProductRepository : IProductRepository
    {

        private  AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

    }
}
