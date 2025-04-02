namespace Assignment17
{
    public class Program
    {
        public delegate void MyDelegate(int x, int y);
        public static void Main(string[] args)
        {
            Program helloWorld = new Program();

            MyDelegate myDelegate = helloWorld.add;
            myDelegate += helloWorld.subtract;
            myDelegate += helloWorld.multiply;
            myDelegate += helloWorld.divide;

            myDelegate.Invoke(42, 23);

        }

        public void add(int x, int y)
        {
            Console.WriteLine($"Addition of {x} + {y} = {x + y}");
        }

        public void subtract(int x, int y)
        {
            Console.WriteLine($"Subtraction of {x} - {y} = {x - y}");
        }

        public void multiply(int x, int y)
        {
            Console.WriteLine($"Multiplication of {x} * {y} = {x * y}");
        }

        public void divide(int x, int y)
        {
            Console.WriteLine($"Division of {x} / {y} = {x / y}");
        }
    }
}