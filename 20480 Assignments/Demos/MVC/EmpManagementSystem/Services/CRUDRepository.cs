using EmpManagementSystem.Models;

namespace EmpManagementSystem.Services
{
    public class CRUDRepository : ICRUD
    {
        private List<Employee> _employees;
        // Constructor
        public CRUDRepository()
        {
            _employees = new List<Employee>();
            _employees.Add(new Employee() { Id=1, Age=34, Address="123 Wallaby Way", Name="Elena", ImageName="elena.jpg",Department=Dept.HR, Salary=8000});
            _employees.Add(new Employee() { Id = 2, Age = 32, Address = "124 Wallaby Way", Name = "Logan", ImageName = "logan.jpg", Department = Dept.IT, Salary = 4000 });
            _employees.Add(new Employee() { Id = 3, Age = 35, Address = "125 Wallaby Way", Name = "Michael", ImageName = "michael.jpg", Department = Dept.Sales, Salary = 6000 });
            _employees.Add(new Employee() { Id = 4, Age = 28, Address = "126 Wallaby Way", Name = "Nathan", ImageName = "nathan.jpg", Department = Dept.Marketing, Salary = 4500 });
        }
        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void DeleteEmployee(int? id)
        {
            var empToDelete = _employees.Find(x => x.Id == id);
            if(empToDelete != null)
            {
                _employees.Remove(empToDelete);
            }
        }

        public Employee GetEmployee(int? id)
        {
            if(id == null)
            {
                return null;
            }
            else
            {
                return _employees.Find(x => x.Id == id);
            }
        }

        public List<Employee> GetEmployees()
        {
            return _employees;
        }

        public int GetMaxID()
        {
            int maxID = _employees.Max(x => x.Id);
            return maxID + 1;
        }

        public void UpdateEmployee(Employee employee)
        {
            var empToUpdate = _employees.Find(x => x.Id == employee.Id);
            if(empToUpdate != null)
            {
                empToUpdate.Id = employee.Id;
                empToUpdate.Name = employee.Name;
                empToUpdate.Address = employee.Address;
                empToUpdate.Department = employee.Department;
                empToUpdate.Salary = employee.Salary;
                empToUpdate.Age = employee.Age;
                empToUpdate.ImageName = employee.ImageName;
            }
        }
    }
}
