using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Implements
{
    public class XMLDatabase : IDatabase
    {
        public void Save(int orderId)
        {
            Console.WriteLine("Write Xml with orderId: " + orderId);
        }
    }
}
