using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class CardPayment
    {
        public string CardNumber { get; set; }
        public string CardHolderName { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }


        public CardPayment(string cardNumber, string cardHolderName, string expiryDate, string cvv)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
            CVV = cvv;
        }
    }
}
