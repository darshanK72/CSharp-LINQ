namespace Assignment11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Your Choice Number From 1,2,3,4,5: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("You Have Entered 1");
                    break;
                case 2:
                    Console.WriteLine("You Have Entered 2");
                    break;
                case 3:
                    Console.WriteLine("You Have Entered 3");
                    break;
                case 4:
                    Console.WriteLine("You Have Entered 4");
                    break;
                case 5:
                    Console.WriteLine("You Have Entered 5");
                    break;
                default:
                    Console.WriteLine("Incorrect Choice");
                    break;
            }

        }
    }
}