using EmpManagementSystem.Models;

namespace EmpManagementSystem.Services
{
    public interface ICRUD
    {
        List<Employee> GetEmployees();
        Employee GetEmployee(int? id);
        void AddEmployee(Employee employee);
        void DeleteEmployee(int? id);
        void UpdateEmployee(Employee employee);
        int GetMaxID();
    }
}
