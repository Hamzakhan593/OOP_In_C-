using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_In_C_
{
    public class Notification
    {
        private readonly IMessageService _messageService;

        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            _messageService.SendMessage(message);
        }


        //// we we dont use interface or base class then for every new service we ll
        //// change the Notification class and we ll also implement the business logic 
        //private EmailService _emailService;
        //private SmsService _smsService;
        //public Notification()
        //{
        //    _emailService = new EmailService();
        //    _smsService = new SmsService();
        //}

        //public void Send(string message)
        //{
        //    _emailService.SendMessage("Email: " + message);
        //    _emailService.SendMessage("SMS: " + message);
        //}

    }
}
