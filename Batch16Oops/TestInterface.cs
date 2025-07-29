using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch16Oops
{
    internal interface ITestInterface
    {
        //method declaration
        void MakePayment(decimal amount);

        void RefundPayment(decimal amount);
    }

    internal interface ITestInterface1
    {
        void MakeUPIPayment(decimal amount);

    }

    public class CreditCardPayment : ITestInterface, ITestInterface1
    {
        //interface method implementation

        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Credit Card Payment of {amount} has been made");

        }

        public void RefundPayment(decimal amount)
        {
            Console.WriteLine($"Credit Card refund of {amount} has been made");
        }

        public void MakeUPIPayment(decimal amount)
        {

            Console.WriteLine($"Credit Card UPI payment of {amount} has been made");
        }
    }

        public class PaypalPayment : ITestInterface1
        {
            public void MakeUPIPayment(decimal amount)
            {
                Console.WriteLine($" PayPal UPI payment of {amount} has been made");
            }

        }
        internal interface TestInterface
        {
            static void Main()
            {
                //caredit card
                ITestInterface creditcard = new CreditCardPayment();
                creditcard.MakePayment(100.5m);
                creditcard.RefundPayment(50.5m);
                ITestInterface1 CreditCard1 = new CreditCardPayment();
                CreditCard1.MakeUPIPayment(60.25m);

                //paypal payment

                ITestInterface1 paypal = new PaypalPayment();
                paypal.MakeUPIPayment(43.8m);

            }


        }
    }

