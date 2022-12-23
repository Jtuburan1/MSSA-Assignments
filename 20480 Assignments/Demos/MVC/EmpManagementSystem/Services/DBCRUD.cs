using EmpManagementSystem.Models;

namespace EmpManagementSystem.Services
{
    public class DBCRUD : ICRUD
    {
        private EmployeeContext _employeeContext;
        public DBCRUD(EmployeeContext employeeContext)
        {
            this._employeeContext = employeeContext;
        }

        public void AddEmployee(Employee employee)
        {
            string dept = employee.Department.ToString();
            switch(dept)
            {
                case "HR":
                    employee.DeptID = 1;
                    break;
                case "Finance":
                    employee.DeptID = 2;
                    break;
                case "IT":
                    employee.DeptID = 3;
                    break;
                case "Marketing":
                    employee.DeptID = 4;
                    break;
                case "Sales":
                    employee.DeptID = 5;
                    break;
            }
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
        }

        public void DeleteEmployee(int? id)
        {
            var empToDelete = _employeeContext.Employees.Find(id);
            if (empToDelete != null)
            {
                _employeeContext.Employees.Remove(empToDelete);
                _employeeContext.SaveChanges();
            }
        }

        public Employee GetEmployee(int? id)
        {
            return _employeeContext.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return new List<Employee>(_employeeContext.Employees);
        }

        public int GetMaxID()
        {
            return _employeeContext.Employees.Max(x => x.Id) + 1;
        }

        public void UpdateEmployee(Employee employee)
        {
            var empToUpdate = _employeeContext.Employees.Find(employee.Id);
            if (empToUpdate != null) 
            {
                empToUpdate.Id = employee.Id;
                empToUpdate.Name = employee.Name;
                empToUpdate.Address = employee.Address;
                empToUpdate.Age = employee.Age;
                empToUpdate.Salary = employee.Salary;
                empToUpdate.Department = employee.Department;
                empToUpdate.ImageName = employee.ImageName;

                string dept = employee.Department.ToString();
                switch (dept)
                {
                    case "HR":
                        empToUpdate.DeptID = 1;
                        break;
                    case "Finance":
                        empToUpdate.DeptID = 2;
                        break;
                    case "IT":
                        empToUpdate.DeptID = 3;
                        break;
                    case "Marketing":
                        empToUpdate.DeptID = 4;
                        break;
                    case "Sales":
                        empToUpdate.DeptID = 5;
                        break;
                }

                _employeeContext.SaveChanges();
            }
        }
    }
}
