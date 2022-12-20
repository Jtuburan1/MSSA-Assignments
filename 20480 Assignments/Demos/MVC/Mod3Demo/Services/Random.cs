namespace Mod3Demo.Services
{
    public class RandomService : IRandom
    {
        private int _random;
        public RandomService()
        {
            Random random = new Random();
            _random = random.Next(500);
        }
        public int GetNumber()
        {
            return _random;
        }
    }
}
