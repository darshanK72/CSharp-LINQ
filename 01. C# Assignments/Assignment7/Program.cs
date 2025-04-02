namespace Assignment7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }

}