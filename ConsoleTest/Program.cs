using ConsoleTest.Implements;
using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterContainer.Create();

            ProcessOrder processOrder = new ProcessOrder();
            processOrder.Checkout();

            Console.ReadLine();
        }


    }
}
