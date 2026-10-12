using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Task3
{
    public class StripeProcessor : PaymentProcessor
    {
        public override string PaymentMethod
        {
            get { return "Stripe"; }
        }

        public override void ProcessPayment(double amount)
        {
            if (ValidateTransaction(amount))
            {
                Console.WriteLine("Payment processed through Stripe: Rs. " + amount);
            }
        }
    }
}