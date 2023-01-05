using System.ComponentModel.DataAnnotations;

namespace ProductManagementSystem.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }

        [DataType(DataType.Currency)]
        public double Salary { get; set; }
    }
}
