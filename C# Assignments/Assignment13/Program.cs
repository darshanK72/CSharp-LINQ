using System.Collections;

namespace Assignment13
{
    public class ProductDemo
    {
        public static int productCount = 0;
        public object? objProductID { get; set; }
        public object? objProductName { get; set; }
        public object? objPrice { get; set; }
        public object? objQuantity { get; set; }
        public object? objAmountPayable { get; set; }

        public ProductDemo()
        {
            ProductDemo.productCount += 1;
            this.objProductID = productCount;
        }

        public override string? ToString()
        {
            return $"Product Id : {this.objProductID}\nProduct Name : {this.objProductName}\nProduct Price : {this.objPrice}\nQuantity : {this.objQuantity}\nAmount Payable : {this.objAmountPayable}\n-----------------------------";
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {

            ArrayList productList = new ArrayList();

            ProductDemo[] products = new ProductDemo[10];

            Console.Write("Do You Want to Add New Product (yes/no) : ");
            string? choice = Console.ReadLine();

            while (choice.ToLower() == "yes" && productList.Count < 10)
            {
                ProductDemo demo = new ProductDemo();
                Console.Write("Enter Name of Product : ");
                demo.objProductName = Console.ReadLine();
                Console.Write("Enter Price : ");
                demo.objPrice = double.Parse(Console.ReadLine());
                Console.Write("Enter Quantity: ");
                demo.objQuantity = int.Parse(Console.ReadLine());
                Console.Write("Enter Amount Payable : ");
                demo.objAmountPayable = double.Parse(Console.ReadLine());


                productList.Add(demo);

                Console.Write("\nDo You Want to Add New Product (yes/no) : ");
                choice = Console.ReadLine();

            }


            Console.WriteLine("\n\n------------------------Products----------------------------\n"); ;
            foreach (var demo in productList)
            {
                Console.WriteLine(demo);
            }
        }
    }
}