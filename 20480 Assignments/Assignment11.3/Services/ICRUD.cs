using Assignment11._3.Models;

namespace Assignment11._3.Services
{
    public interface ICRUD
    {
        public List<Product> GetProducts();
        public void Create(Product product);
        public Product Read(int productID);
        public void Update(Product product);
        public void Delete(int productID);
    }
}
