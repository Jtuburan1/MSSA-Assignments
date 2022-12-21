using System.ComponentModel.DataAnnotations;
namespace EmpManagementSystem.Models
{
    public enum Dept
    {
        HR=1,
        Finance,
        IT,
        Marketing,
        Sales
    }
    public class Employee
    {
        [Display(Name="Employee ID")]
        [Required(ErrorMessage = "This field must be filled.")]
        public int Id { get; set; }
        [Display(Name = "Employee Name")]
        [Required(ErrorMessage = "This field must be filled.")]
        [MaxLength(50)]
        [AllLetters(ErrorMessage = "Please enter letters only.")]
        public string? Name { get; set; }
        [Range(18,80,ErrorMessage = "The age needs to be between 18 and 80.")]
        public int Age { get; set; }
        [Display(Name = "Home Address")]
        [DataType(DataType.MultilineText)]
        [MaxLength(250,ErrorMessage = "Address cannot be longer than 250 characters.")]
        public string? Address { get; set; }
        [DataType(DataType.Currency)]
        public double Salary { get; set; }
        public string? ImageName { get; set; }
        public Dept Department { get; set; }
    }
}
