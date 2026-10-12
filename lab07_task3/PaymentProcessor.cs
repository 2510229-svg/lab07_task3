using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Task3
{
    public abstract class PaymentProcessor
    {
        public abstract string PaymentMethod { get; }

        public bool ValidateTransaction(double amount)
        {
            if (amount > 0)
            {
                return true;
            }

            Console.WriteLine("Invalid amount!");
            return false;
        }

        public abstract void ProcessPayment(double amount);
    }
}