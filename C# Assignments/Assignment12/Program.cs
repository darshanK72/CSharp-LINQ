namespace Assignment12
{
    public class Student
    {
        public int rollNumber { get; set; } = 0;
        public string studentName { get; set; } = string.Empty;
        public DateTime dateOfBirth { get; set; } = DateTime.MinValue;
        public int age { get; set; } = 0;
        public double percentages { get; set; } = 0.0;
        public string address { get; set; } = string.Empty;

        public override string? ToString()
        {
            return $"Name : {this.studentName}\nRoll No : {this.rollNumber}\nDate of Birth : {this.dateOfBirth}\nAge : {this.age}\nPercentages : {this.percentages}\nAddress : {this.address}\n-----------------------------";
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.rollNumber = 101;
            s1.studentName = "Darshan Khairnar";
            s1.age = 15;
            s1.dateOfBirth = new DateTime(2000, 12, 7);
            s1.percentages = 78.52;
            s1.address = "Anand Nagar, Malegaon, Soygaon";



            Console.WriteLine(s1);


        }
    }
}
