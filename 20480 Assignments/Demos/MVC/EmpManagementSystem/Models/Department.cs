using System.ComponentModel.DataAnnotations;

namespace EmpManagementSystem.Models
{
    public class Department
    {
        [Key]
        public int DeptID { get; set; }

        public string DeptName { get; set; }

        // 1 department, many employees
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
