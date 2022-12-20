using Assignment11._3.Models;

namespace Assignment11._3.Services
{
    public class CRUD : ICRUD
    {
        private List<Product> _products;
        public CRUD()
        {
            _products = new List<Product>();
            _products.Add(new Product() { ID = 1, productName = "Soap", productDescription = "Cleans whatever you need.", productPrice = 4.99 });
            _products.Add(new Product() { ID = 2, productName = "Shampoo", productDescription = "Cleans your hair.", productPrice = 5.99 });
        }
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int productID)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            return _products;
        }

        public Product Read(int productID)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
