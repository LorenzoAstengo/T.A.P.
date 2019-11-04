using System;
using  EmailSenderInterfaces;

namespace EmailSenderImplementation2
{
    public class EmailSenderImplementation2 : IEmailSender
    {
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("Do tou want to send this email to: %s?", to);
            Console.WriteLine("Body: %s", body);
            Console.WriteLine("Press Y/N:");
            string res = Console.ReadLine();
            if (res.Contains("Y"))
                return true;
            else
                return false;
        }
    }
}
