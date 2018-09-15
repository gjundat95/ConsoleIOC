using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class Cart
    {
        private IDatabase database;
        private ILogger logger;
        private IEmailSender emailSender;

        public Cart(IDatabase _db, ILogger _logger, IEmailSender _ms) {
            this.database = _db;
            this.logger = _logger;
            this.emailSender = _ms;
        }

        public void CheckOut(int orderId, int userId) {
            this.database.Save(orderId);
            this.logger.SaveLogger();
            this.emailSender.Send(userId);
        }
    }
}
