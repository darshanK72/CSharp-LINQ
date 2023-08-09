namespace Assignment18
{
    public class Program
    {
        class NotSufficientBalanceException : ApplicationException
        {
            public NotSufficientBalanceException(string message) : base(message)
            {

            }
        }
        public class Customer
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public double Balance { get; set; }


            public Customer(string name, string address, double balance)
            {
                Name = name;
                Address = address;
                Balance = balance;
            }

            public void Withdraw(double amount)
            {
                if (Balance == 0 || Balance < amount)
                {
                    throw new NotSufficientBalanceException("Balance in Account is Not Sufficient to Withdraw Money !!");
                }

                Balance = Balance - amount;

                Console.WriteLine("Remaining Balance in Account : " + Balance);

            }

        }


        public static void Main(string[] args)
        {
            Customer customer = new Customer("Darshan Khairnar", "Malegaon", 40000);

            Console.Write("Enter Ammount to Withdraw : ");
            double ammount = Convert.ToDouble(Console.ReadLine());

            try
            {
                customer.Withdraw(ammount);
            }
            catch (NotSufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}