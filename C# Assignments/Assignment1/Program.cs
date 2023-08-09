namespace Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Two Numbers : ");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Operations :\n+ : Addition\n- : Subtracttion\n* : Multiplication\n/ : Division\nEnter Operation :");
            char op = Console.ReadLine()[0];

            switch (op)
            {
                case '+':
                    Add(a, b);
                    break;
                case '-':
                    Console.WriteLine($"a - b = {Subtract(a, b)}");
                    break;
                case '*':
                    Multiply(a, b);
                    break;
                case '/':
                    Divide(a, b);
                    break;
            }
            // if(op == "+")
            // {
            //   Add(a,b);

            // }else if(op == "-")
            // {
            //   Subtract(a,b);
            // }
            // else if(op == "*")
            // {
            //   Multiply(a,b);

            // }else if(op == "/")
            // {
            //     Divide(a,b); 
            // }
        }

        public static void Add(double a, double b)
        {
            //Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine("a + b = " + (a + b));
            //Console.WriteLine("a + b = {0}",(a+b));
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }

        public static void Multiply(double a, double b)
        {
            Console.WriteLine($"a * b = {a * b}");
        }

        public static void Divide(double a, double b)
        {
            Console.WriteLine($"a / b = {a / b}");
        }
    }


}