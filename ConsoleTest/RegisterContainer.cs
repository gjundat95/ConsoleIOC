using ConsoleTest.Implements;
using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class RegisterContainer
    {
        public static void Create() {
            //DIContainer.SetModule<IDatabase, Database>();
            DIContainer.SetModule<ILogger, Logger>();
            DIContainer.SetModule<IEmailSender, EmailSender>();
            DIContainer.SetModule<IDatabase, XMLDatabase>();
            DIContainer.SetModule<Cart, Cart>();
        }
    }
}
