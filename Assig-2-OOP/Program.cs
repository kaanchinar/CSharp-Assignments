namespace Assig_2_OOP
{
    public class Person
    {
        private string _name;
        private int _birthyear;

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public int Birthyear
        {
            get => _birthyear;
            set => _birthyear = value;
        }
    }
    public class Student : Person
    {
        private string _major;

        public string Major
        {
            get => _major;
            set => _major = value;
        }

        public Student(string major, string name, int birth)
        {
            Major = major;
            Name = name;
            Birthyear = birth;
        }

        public void PrintInformation()
        {
            Console.WriteLine("About this student:");
            Console.WriteLine($"Name: {Name}\n" +
                              $"Birth year: {Birthyear}\n" +
                              $"Major: {Major}");
        }
        
    }
    public class Instructor : Person
    {
        private int _salary;
        public int Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public Instructor(int salary, string name, int birth)
        {
            Salary = salary;
            Name = name;
            Birthyear = birth;
        }

        public void PrintInformation()
        {
            Console.WriteLine("About this instructor:");
            Console.WriteLine($"Name: {Name}\n" +
                              $"Birth date: {Birthyear}\n" +
                              $"Salary: {Salary}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
           var student = new Student("CS", "John", 2008);
           var instructor = new Instructor(1300, "Habib", 1981);

           instructor.PrintInformation();
           student.PrintInformation();

        }
    }
}
