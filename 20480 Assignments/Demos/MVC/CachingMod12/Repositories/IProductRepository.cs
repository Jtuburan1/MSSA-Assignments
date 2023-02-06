using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CachingMod12.Models;

namespace CachingMod12.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Dictionary<int, string> GetProductNames();
        Product GetProduct(int id);
    }
}
