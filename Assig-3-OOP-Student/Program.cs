namespace Assig_3_OOP
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
        public int StudentID { get; set; }
        public int CourseID { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public Student(int studentID, string name, int courseID, string gender, string phoneNumber)
        {
            StudentID = studentID;
            Name = name;
            CourseID = courseID;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }

        public void UpdatePhoneNumber(string newPhoneNumber)
        {
            PhoneNumber = newPhoneNumber;
        }

        public virtual void PrintInformation()
        {
            Console.WriteLine("About this student:");
            Console.WriteLine($"Student ID: {StudentID}\n" +
                              $"Name: {Name}\n" +
                              $"Course ID: {CourseID}\n" +
                              $"Gender: {Gender}\n" +
                              $"Phone Number: {PhoneNumber}");
        }
    }

    public class Hosteller : Student
    {
        public string HostelName { get; set; }
        public int RoomNumber { get; set; }

        public Hosteller(int studentID, string name, int courseID, string gender, string phoneNumber, string hostelName, int roomNumber)
            : base(studentID, name, courseID, gender, phoneNumber)
        {
            HostelName = hostelName;
            RoomNumber = roomNumber;
        }

        public void UpdateRoomNumber(int newRoomNumber)
        {
            RoomNumber = newRoomNumber;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine($"Hostel Name: {HostelName}\n" +
                              $"Room Number: {RoomNumber}");
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
            var student = new Student(1, "John", 101, "Male", "1234567890");
            var hosteller = new Hosteller(2, "Jane", 102, "Female", "0987654321", "Sunrise Hostel", 12);
            var instructor = new Instructor(1300, "Habib", 1981);

            instructor.PrintInformation();
            student.PrintInformation();
            hosteller.PrintInformation();

            // Update room number and phone number
            hosteller.UpdateRoomNumber(15);
            hosteller.UpdatePhoneNumber("1122334455");

            Console.WriteLine("\nUpdated Hosteller Details:");
            hosteller.PrintInformation();
        }
    }
}
