using System.Collections.Generic;
using Utility_001.Data;

public interface IProductRepository
{
    IEnumerable<Product> GetAllProducts();
}
