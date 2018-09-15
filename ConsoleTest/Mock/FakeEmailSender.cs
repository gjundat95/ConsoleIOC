using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Mock
{
    public class FakeEmailSender : IEmailSender
    {
        public void Send(int userId)
        {
            Console.WriteLine("Fake send email with id: " + userId);
        }
    }
}
