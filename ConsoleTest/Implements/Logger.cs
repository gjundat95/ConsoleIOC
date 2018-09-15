using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest.Implements
{
    public class Logger : ILogger
    {
        public void SaveLogger()
        {
            Console.WriteLine("Write logger real time");
        }
    }
}
