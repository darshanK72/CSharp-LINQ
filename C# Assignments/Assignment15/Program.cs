namespace Assignment15
{
    public abstract class Employee
    {
        public static int employeeCount = 0;
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Department { get; set; }
        public double Salary { get; set; }

        public Employee()
        {
            this.EmployeeId = ++employeeCount;
        }

        public Employee(string employeeName, string address, string city, string department, double salary)
        {
            this.EmployeeId = ++employeeCount;
            EmployeeName = employeeName;
            Address = address;
            City = city;
            Department = department;
            Salary = salary;
        }

        public abstract double CalculateSalary();


    }

    public class ContractEmployee : Employee
    {
        public double Perks { get; set; } = 2000;

        public ContractEmployee(string employeeName, string address, string city, string department, double salary, double perks) : base(employeeName, address, city, department, salary)
        {
            this.Perks = perks;
        }

        public override double CalculateSalary()
        {
            return this.Salary + this.Perks;
        }


        public override string? ToString()
        {
            return $"Employee Name : {this.EmployeeName}\nSalary : {this.Salary}";
        }

    }

    public class PermenentEmployee : Employee
    {
        public double Perks { get; set; } = 5000;
        public int NoOfLeaves { get; set; } = 22;
        public double ProvidendFund { get; set; }


        public PermenentEmployee(string employeeName, string address, string city, string department, double salary, double perks, int noOfLeaves, double providendFund) : base(employeeName, address, city, department, salary)
        {
            this.Perks = perks;
            this.NoOfLeaves = noOfLeaves;
            this.ProvidendFund = providendFund;
        }

        public override double CalculateSalary()
        {
            return this.Salary + this.Perks - this.ProvidendFund;
        }

        public override string? ToString()
        {
            return $"Employee Name : {this.EmployeeName}\nSalary : {this.Salary}";
        }
    }


    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Total No of Employes : ");
            int noOfEmployes = Convert.ToInt32(Console.ReadLine());

            Employee[] employes = new Employee[noOfEmployes];

            int i = 0;

            while (i < noOfEmployes)
            {

                Employee employee;

                Console.Write("Enter Type of Customer\n1. Contract\n2. Permenent\n Your Choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());



                Console.Write("Enter Employee Details\n");
                Console.Write("Name : ");
                string? name = Console.ReadLine();
                Console.Write("Address : ");
                string? address = Console.ReadLine();
                Console.Write("City : ");
                string? city = Console.ReadLine();
                Console.Write("Department : ");
                string? department = Console.ReadLine();
                Console.Write("Salary : ");
                double salary = Convert.ToDouble(Console.ReadLine());
                Console.Write("Perks : ");
                double perks = Convert.ToDouble(Console.ReadLine());

                int noOfLeaves;
                double providendFund;

                if (choice == 1)
                {
                    employee = new ContractEmployee(name, address, city, department, salary, perks);
                    employes[i] = employee;
                }
                else if (choice == 2)
                {
                    Console.Write("No of Leaves: ");
                    noOfLeaves = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Providand Fund : ");
                    providendFund = Convert.ToDouble(Console.ReadLine());

                    employee = new PermenentEmployee(name, address, city, department, salary, perks, noOfLeaves, providendFund);
                    employes[i] = employee;
                }
                else
                {
                    Console.WriteLine("Incorrect Choice");
                }



                i++;

            }

            Console.WriteLine("\n\n------------------- Salary of Employes ----------------------\n");
            foreach (Employee emp in employes)
            {
                Console.WriteLine(emp);
            }
        }
    }
}