
namespace Lab7Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcessor paypal = new PayPalProcessor();
            PaymentProcessor stripe = new StripeProcessor();

            double amount = 5000;

            Console.WriteLine("Valid Transaction:");

            paypal.ProcessPayment(amount);
            stripe.ProcessPayment(amount);

            Console.WriteLine();

            Console.WriteLine("Invalid Transaction:");

            paypal.ProcessPayment(-100);
            stripe.ProcessPayment(-100);
        }
    }
}
