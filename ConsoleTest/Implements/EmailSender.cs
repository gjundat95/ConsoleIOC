using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Implements
{
    public class EmailSender : IEmailSender
    {
        public void Send(int userId)
        {
            Console.WriteLine("Sending email to user: " + userId);
        }
    }
}
