namespace Assignment6
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine($"{n1} is Even Number");
            }
            else
            {
                Console.WriteLine($"{n1} is Odd Number");
            }
        }
    }
}