using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._3
{
    public static class DataSource
    {
        public static List<Student> Students;
        public static List<Teacher> Teachers;


        public static void CreateData()
        {
            Students = new List<Student>()
            {
                new Student() { StudentID = "123456", StudentName = "Joe Tuburan", GPA = 3.5m }
            };

            Teachers = new List<Teacher>()
            {
                new Teacher() {UserID = "Teacher", Password = "Admin"}
            };
        }
    }
}
