using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Net;

using System.Xml.Linq;

namespace EmpManagementSystem.Models
{
    // class representing the db
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; } // employee table
        public DbSet<Department> Departments { get; set; } // department table

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data seeding
            modelBuilder.Entity<Department>().HasData(
                new Department { DeptID = 1, DeptName = "HR"},
                new Department { DeptID = 2, DeptName = "Finance"},
                new Department { DeptID = 3, DeptName = "IT"},
                new Department { DeptID = 4, DeptName = "Marketing"},
                new Department { DeptID = 5, DeptName = "Sales"}
            );
            modelBuilder.Entity<Employee>().HasData(
                new Employee {Id = 1, DeptID = 1, Age = 34, Address = "123 Wallaby Way", Name = "Elena", ImageName = "elena.jpg", Department = Dept.HR, Salary = 8000},
                new Employee { Id = 2, DeptID = 3, Age = 32, Address = "124 Wallaby Way", Name = "Logan", ImageName = "logan.jpg", Department = Dept.IT, Salary = 4000 },
                new Employee { Id = 3, DeptID = 5, Age = 35, Address = "125 Wallaby Way", Name = "Michael", ImageName = "michael.jpg", Department = Dept.Sales, Salary = 6000 },
                new Employee { Id = 4, DeptID = 4, Age = 28, Address = "126 Wallaby Way", Name = "Nathan", ImageName = "nathan.jpg", Department = Dept.Marketing, Salary = 4500 }
                );
        }
    }
}
