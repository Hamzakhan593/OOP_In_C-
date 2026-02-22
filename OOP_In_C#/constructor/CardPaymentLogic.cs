using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_.constructor
{
    public class CardPaymentLogic
    {
        public void printCardDetails(CardPayment cardPayment)
        {
            Console.WriteLine("Card Payment Details:");
            Console.WriteLine($"Card Number: {cardPayment.CardNumber}");
            Console.WriteLine($"Card Holder Name: {cardPayment.CardHolderName}");
            Console.WriteLine($"Expiry Date: {cardPayment.ExpiryDate}");
            Console.WriteLine($"CVV: {cardPayment.CVV}");
            Console.WriteLine();
        }
    }
}
