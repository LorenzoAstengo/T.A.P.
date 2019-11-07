using System;
using EmailSenderInterfaces;
using TinyDependencyInjectionContainer;

namespace DiContainer
{
    class Program
    {
        static void Main()
        {
            var resolver= new InterfaceResolver("TDIC_Configuration.txt");
            var sender = resolver.Instantiate<IEmailSender>();
            sender.SendEmail("pippo", "pluto");
        }
    }
}
