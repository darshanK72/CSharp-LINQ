/*using System.Threading;

ICICI Bank want’s to implement SMS alert fascility to the customers whenever they pay the Credit Card Bill. The CreditCard class contains the following fields.

CreditCardNo, CardHolderName, BalanceAmount, CreditLimit.

The class has three functions. GetBalance(), GetCreditLimit(), and MakePayment(). Whenever the MakePayment() method is called, it should update the BalanceAmount and raise an event. The event should send a message. ( You don’t need to write a logic to send the sms. Only print the message saying amount is credited.)

Task to be performed:

Define a class CreditCard

Define a Delegate to Handle the Event

Define an event which will be raised whenever the payment is made.

Create a Console client application, and try the functionality.
*/
using MyClassLibrary;
using System.Security.Cryptography.X509Certificates;

namespace Assignment22
{
    class CreditCard
    {
        public delegate void MyDelegate();

        public event MyDelegate myEvent;
        public int CreditCardNo { get; set; }
        public string CardHolderName { get; set; }
        public double BalanceAmount { get; set; }

        public double CreditLimit { get; set; }

        public double GetCreditLimit()
        {
            return CreditLimit;
        }

        public double GetBalance()
        {
            return BalanceAmount;
        }

        public void MakePayment(double amount)
        {
            if (this.BalanceAmount < amount || this.BalanceAmount - amount < this.CreditLimit)
            {
                myEvent();
            }
            else
            {
                Console.WriteLine("Payment Done!!");
            }

        }
    }
 
    public class Program
    {
        public static void Main(string[] args)
        {
            CreditCard creditCard = new CreditCard();
            creditCard.CreditCardNo = 101;
            creditCard.BalanceAmount = 5000;
            creditCard.CreditLimit = 1000;

            creditCard.myEvent += new CreditCard.MyDelegate(MyEventHandler);

            creditCard.MakePayment(5000);

        }

        public static void MyEventHandler()
        {
            Class1 class1 = new Class1();
            class1.Hello();

            Console.WriteLine("Can't Complete Payment");
        }


    }
}