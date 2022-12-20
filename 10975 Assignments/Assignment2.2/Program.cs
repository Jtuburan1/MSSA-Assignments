namespace Assignment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person newPerson = new Person();
            Console.WriteLine("Input your first name:");
            newPerson.FirstName = Console.ReadLine()!;
            Console.WriteLine("Input your last name:");
            newPerson.LastName = Console.ReadLine()!;
            Console.WriteLine("Input your age:");
            newPerson.Age = int.Parse(Console.ReadLine()!);
            Console.WriteLine("Input your current address:");
            newPerson.Address = Console.ReadLine()!;
            WriteToFile($"{newPerson.FirstName} {newPerson.LastName}", newPerson);
            Console.WriteLine();
            Console.WriteLine("The below information was saved to a file:");
            ReadFile($"{newPerson.FirstName} {newPerson.LastName}");
            TipCalculator tipCalculator = new TipCalculator();
            tipCalculator.TipCaclulatorMenu();
        }

        static void WriteToFile(string fileName, Person newPerson)
        {
            StreamWriter fileWriter = new StreamWriter(fileName);
            fileWriter.Write($"First name: {newPerson.FirstName}\nLast name: {newPerson.LastName}\nAge: {newPerson.Age}\nCurrent Address: {newPerson.Address}");
            fileWriter.Close();
        }

        static void ReadFile(string fileName)
        {
            StreamReader fileReader = new StreamReader(fileName);
            Console.WriteLine(fileReader.ReadToEnd());
        }
    }

    internal class Person
    {
        private string _firstName;
        private string _lastName;
        private int _age;
        private string _address;

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Age { get => _age; set => _age = value; }
        public string Address { get => _address; set => _address = value; }
    }
}