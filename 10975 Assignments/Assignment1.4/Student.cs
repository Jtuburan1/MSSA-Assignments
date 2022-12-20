using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1._4
{
    internal class Student
    {
        private int _studentid;
        private string _studentfname;
        private char _studentgrade;

        public Student(int studentID, string studentFName, char studentGrade)
        {
            this._studentid = studentID;
            this._studentfname = studentFName;
            this._studentgrade = studentGrade;
        }

        public int studentID
        {
            get { return _studentid; }
            set
            {
                if(studentID >= 0)
                {
                    _studentid = value;
                }
            }
        }
        public string studentFName
        {
            get { return _studentfname; }
            set { _studentfname = value; }
        }
        public char studentGrade
        {
            get { return _studentgrade; }
            set { _studentgrade = value; }
        }

        public void StudentInfo()
        {
            Console.WriteLine("Student ID is: {0}, Student First Name is: {1}, Current Grade is: {2}", this.studentID, this.studentFName, this.studentGrade);
        }
    }
}
