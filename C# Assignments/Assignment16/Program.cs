namespace Assignment16
{
    public class Program
    {
        public delegate int MyDelegate(int x);
        public static void Main(string[] args)
        {
            MyDelegate deleg = Factorial;

            Console.WriteLine("Factorial of 20 : " + deleg(7));

        }

        public static int Factorial(int x)
        {
            if (x == 0)
                return 1;
            return x * Factorial(x - 1);
        }
    }
}