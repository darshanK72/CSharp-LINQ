namespace Assignment9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Name Of Student : ");
            string name = Console.ReadLine();

            int[] marks = new int[5];

            Console.WriteLine("Enter Marks of 5 Subjects Out of 100 : ");
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write($"Subject {i + 1} Marks : ");
                int? temp = Convert.ToInt32(Console.ReadLine());
                if (temp != null)
                {
                    marks[i] = temp.Value;
                }
                else
                {
                    marks[i] = 0;
                }
            }

            double avg = 0.0;
            foreach (int mark in marks)
            {
                avg += mark;
            }

            avg /= marks.Length;

            Console.WriteLine($"Grades of Student : {avg}");
        }
    }
}