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
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public double Salary { get; set; }
        public string? ImageName { get; set; }
        public Dept Department { get; set; }
    }
}
