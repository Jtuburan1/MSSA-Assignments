using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Assignment4._4
{
    public enum Role { Owner, Employee }
    public static class DataSource
    {
        public static List<Owner> AccountOwners;
        public static List<Employees> BankEmployees;
        public static List<Accounts> AmountOfMoney;


        public static void CreateAccount()
        {
            AccountOwners = new List<Owner>()
            {
                new Owner() {AccountNumber = 1, UserName = "jtuburan", Password = "password", AccountName = "Joseph Tuburan"},
                new Owner() {AccountNumber = 2, UserName = "asiercks", Password = "password", AccountName = "Andrew Siercks" },
                new Owner() {AccountNumber = 3, UserName = "elapice", Password = "password", AccountName = "Evan Lapice" }
            };
            BankEmployees = new List<Employees>()
            {
                new Employees() { EmployeeID = 1, UserName = "bregent", Password = "password", FirstName = "Bob", LastName = "Regent"},
                new Employees() { EmployeeID = 2, UserName = "dphilips", Password = "password", FirstName = "Dian", LastName = "Philips" }
            };
            AmountOfMoney = new List<Accounts>()
            {
                new Accounts() { AccountNumber = 1, Checking = 1500, Savings = 2000 },
                new Accounts() { AccountNumber = 2, Checking = 1500, Savings = 2000 },
                new Accounts() { AccountNumber = 3, Checking = 1500, Savings = 2000 }
            };
        }
    }

    public class Owner
    {
        public int AccountNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccountName { get; set; }

        public Owner(int accountNumber, string userName, string pass, string accountName)
        {
            AccountNumber = accountNumber;
            UserName = userName;
            Password = pass;
            AccountName = accountName;
        }

        public Owner()
        {
            AccountNumber = 0;
            UserName = String.Empty;
            Password = String.Empty;
            AccountName = String.Empty;
        }
    }

    public class Employees
    {
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employees(int employeeID, string userName, string password, string firstName, string lastName)
        {
            EmployeeID = employeeID;
            UserName = userName;
            Password = password;
            FirstName = firstName;
            LastName = lastName;
        }

        public Employees()
        {
            EmployeeID = 0;
            UserName = String.Empty;
            Password = String.Empty;
            FirstName = String.Empty;
            LastName = String.Empty;
        }
    }

    public class Accounts
    {
        public int AccountNumber { get; set; }
        public int Checking { get; set; }
        public int Savings { get; set; }

        public Accounts(int accountID, int checking, int savings)
        {
            AccountNumber = accountID;
            Checking = checking;
            Savings = savings;
        }
        
        public Accounts()
        {
            AccountNumber = 0;
            Checking = 0;
            Savings = 0;
        }
    }
}
