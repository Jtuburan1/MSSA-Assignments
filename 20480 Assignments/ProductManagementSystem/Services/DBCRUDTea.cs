using ProductManagementSystem.Models;

namespace ProductManagementSystem.Services
{
    public class DBCRUDTea : ITeaRepository
    {
        private TeaContext _teaContext;
        public DBCRUDTea(TeaContext teaContext)
        {
            _teaContext = teaContext;
        }

        public void AddTea(Tea tea)
        {
            string typ = tea.TypeOfTea.ToString();
            switch(typ)
            {
                case "Black":
                    tea.TypeID = 1;
                    break;
                case "Green":
                    tea.TypeID = 2;
                    break;
                case "White":
                    tea.TypeID = 3;
                    break;
                case "Oolong":
                    tea.TypeID = 4;
                    break;
                case "Puerh":
                    tea.TypeID = 5;
                    break;
                case "Purple":
                    tea.TypeID = 6;
                    break;
                case "Herbal":
                    tea.TypeID = 7;
                    break;
            }
            _teaContext.Teas.Add(tea);
            _teaContext.SaveChanges();
        }

        public void DeleteTea(int? id)
        {
            var teaToDelete = _teaContext.Teas.Find(id);
            if(teaToDelete != null)
            {
                _teaContext.Teas.Remove(teaToDelete);
                _teaContext.SaveChanges();
            }
        }

        public List<Tea> GetAllTeas()
        {
            return new List<Tea>(_teaContext.Teas);
        }

        public int GetMaxID()
        {
            return _teaContext.Teas.Max(x => x.Id) + 1;
        }

        public Tea GetTea(int? id)
        {
            return _teaContext.Teas.Find(id);
        }

        public void UpdateTea(Tea tea)
        {
            var teaToUpdate = _teaContext.Teas.Find(tea.Id);
            if (teaToUpdate != null)
            {
                teaToUpdate.Id = tea.Id;
                teaToUpdate.Name = tea.Name;
                teaToUpdate.Description = tea.Description;
                teaToUpdate.Price = tea.Price;
                teaToUpdate.ImageName = tea.ImageName;

                string typ = tea.TypeOfTea.ToString();
                switch (typ)
                {
                    case "Black":
                        teaToUpdate.TypeID = 1;
                        break;
                    case "Green":
                        teaToUpdate.TypeID = 2;
                        break;
                    case "White":
                        teaToUpdate.TypeID = 3;
                        break;
                    case "Oolong":
                        teaToUpdate.TypeID = 4;
                        break;
                    case "Puerh":
                        teaToUpdate.TypeID = 5;
                        break;
                    case "Purple":
                        teaToUpdate.TypeID = 6;
                        break;
                    case "Herbal":
                        teaToUpdate.TypeID = 7;
                        break;
                }

                _teaContext.SaveChanges();
            }
        }
    }
}
