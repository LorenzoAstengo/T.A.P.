using System;
using EmailSenderInterfaces;

namespace EmailSenderImplementation1
{
    public class EmailSenderImplementation1 : IEmailSender
    {
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("Sending mail to: %s", to);
            Console.WriteLine("Body: %s", body);
            return true;
        }
    }
}
