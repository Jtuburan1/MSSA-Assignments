using ProductManagementSystem.Models;

namespace ProductManagementSystem.Services
{
    public class TeaRepository : ITeaRepository
    {
        private List<Tea> _tea;
        public TeaRepository()
        {
            _tea = new List<Tea>();
            _tea.Add(new Tea() { Id = 1, Name = "Sencha", Description = "Sencha is a type of Japanese ryokucha which is prepared by infusing the processed whole tea leaves in hot water", ImageName = "sencha.jpg", Price = 16.99 });
            _tea.Add(new Tea() { Id = 2, Name = "White Tea", Description = "White tea may refer to one of several styles of tea which generally feature young or minimally processed leaves of the Camellia sinensis plant", ImageName = "whitetea.jpg", Price = 8.99 });
            _tea.Add(new Tea() { Id = 3, Name = "Matcha", Description = "Matcha is a Chinese green tea variety that is unique for its harvesting, processing, and preparation methods. Three or four weeks before the harvest, the bush (Camellia sinensis) is covered to prevent direct sunlight, allowing the leaves to grow in the shade.\r\n\r\nAfter the harvest, the leaves are cleaned from stems and veins and are then processed into a fine powder. Unlike most tea varieties, matcha always comes in a powdered form—the practice was first introduced in China, but it remained a standard in Japan", ImageName = "matcha.jpg", Price = 24.99 });
            _tea.Add(new Tea() { Id = 4, Name = "Oolong", Description = "Oolong is a semi-oxidized tea that can vary depending on the leaf style, level of oxidation, color, and the roasting degree. Falling somewhere between green and black teas, it is one of the most complex varieties regarding production, and it can take on a wide variety of flavors and aromas.\r\n\r\nTheir color can vary from pale green or yellow to dark orange, while the aromas often include notes of melons, apricots, wood, orchids, or spices. The level of oxidation can vary anywhere from 10-80%. The less oxidized styles resemble green teas, while more oxidized varieties, typically over 50% percent, share more characteristics with black teas.", ImageName = "oolong.jpg", Price = 21.99 });
            _tea.Add(new Tea() { Id = 5, Name = "Darjeeling", Description = "This prestigious tea was named after the Indian city of Darjeeling, the center of Bengali tea cultivation and once the starting point of a caravan route to Tibet. Even today this ancient city is still best known for the very best quality tea of the same name.\r\n\r\nThe tea cultivation in the West Bengal Darjeeling district goes back to Englishman Arthur Campbell (1805-1874) who experimented with different types of tea in his private garden in the wider Darjeeling area. This led to establishing the Darjeeling Company in 1864 which was renamed in 1896 to Darjeeling Consolidated Tea Company. ", ImageName = "darjeeling.jpg", Price = 15.80 });
        }
        public void AddTea(Tea tea)
        {
            _tea.Add(tea);
        }

        public void DeleteTea(int? id)
        {
            var teaToDelete = _tea.Find(x => x.Id == id);
            if(teaToDelete != null)
            {
                _tea.Remove(teaToDelete);
            }
        }

        public List<Tea> GetAllTeas()
        {
            return _tea;
        }

        public int GetMaxID()
        {
            int maxID = _tea.Max(x => x.Id);
            return maxID + 1;
        }

        public Tea GetTea(int? id)
        {
            if(id == null)
            {
                return null;
            }
            else
            {
                return _tea.Find(x => x.Id == id);
            }
        }

        public void UpdateTea(Tea tea)
        {
            var teaToUpdate = _tea.Find(x => x.Id == tea.Id);
            if(teaToUpdate != null )
            {
                teaToUpdate.Id = tea.Id;
                teaToUpdate.Name = tea.Name;
                teaToUpdate.Description = tea.Description;
                teaToUpdate.Price = tea.Price;
                teaToUpdate.ImageName = tea.ImageName;
            }
        }
    }
}
