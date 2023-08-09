namespace Assignment8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of Array :");
            int length = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[length];

            Console.WriteLine("Enter Elements of Array : ");
            for (int i = 0; i < length; i++)
            {
                arr[i] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("Elements of Array : ");
            // for(int i = 0; i < length; i++)
            // {
            //     Console.WriteLine(arr[i]);
            // }

            foreach (string ele in arr)
            {
                Console.WriteLine(ele);
            }
        }
    }
}
