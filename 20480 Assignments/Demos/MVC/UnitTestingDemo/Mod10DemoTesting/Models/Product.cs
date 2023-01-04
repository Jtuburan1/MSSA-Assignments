namespace Mod10DemoTesting.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float BasePrice { get; set; }
        public string Description { get; set; }
        public string ImageName { get; set; }
        public string FormattedPrice
        {
            get
            {
                return BasePrice.ToString($"C2");
            }
        }
    }
}
