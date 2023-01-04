using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using ProductsWebsite.Models;
using Mod10DemoTesting.Models;
namespace Mod10DemoTesting.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
    }
}
