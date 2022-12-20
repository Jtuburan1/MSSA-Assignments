using ProductManagementSystem.Models;

namespace ProductManagementSystem.Services
{
    public interface ITeaRepository
    {
        List<Tea> GetAllTeas();
        Tea GetTea(int? id);
        void AddTea(Tea tea);
        void DeleteTea(int? id);
        void UpdateTea(Tea tea);
        int GetMaxID();
    }
}
