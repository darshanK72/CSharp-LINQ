namespace Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool b1 = true;
            byte b2 = 42;
            char c1 = 'H';
            short s1 = 772;
            int i1 = 52;
            long l1 = 752732;
            float f1 = 634.52f;
            double d1 = 52324324.523;
            decimal d2 = 52323455.234M;
            string name = "Darshan Khairnar";


            Object ob = new Object();

            ob = "This is String";
            Console.WriteLine($"Object ob = {ob}");

            ob = 526;
            Console.WriteLine($"Object ob = {ob}");

            ob = 723.523f;
            Console.WriteLine($"Object ob = {ob}");

            ob = 8523.23534;
            Console.WriteLine($"Object ob = {ob}");

            ob = 872734.523525M;
            Console.WriteLine($"Object ob = {ob}");



            Console.WriteLine($"Boolean b1 = {b1}");
            Console.WriteLine($"Byte b2 = {b2}");
            Console.WriteLine($"Char c1 = {c1}");
            Console.WriteLine($"Short s1 = {s1}");
            Console.WriteLine($"Int i1 = {i1}");
            Console.WriteLine($"Long l1 = {l1}");
            Console.WriteLine($"Float f1 = {f1}");
            Console.WriteLine($"Doluble d1 = {d1}");
            Console.WriteLine($"Decimal d2 = {d2}");
            Console.WriteLine($"String name = {name}");

        }
    }


}