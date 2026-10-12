using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Task3
{
    public class PayPalProcessor : PaymentProcessor
    {
        public override string PaymentMethod
        {
            get { return "PayPal"; }
        }

        public override void ProcessPayment(double amount)
        {
            if (ValidateTransaction(amount))
            {
                Console.WriteLine("Payment processed through PayPal: Rs. " + amount);
            }
        }
    }
}