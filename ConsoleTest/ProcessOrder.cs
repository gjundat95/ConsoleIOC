using ConsoleTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    public class ProcessOrder
    {
        public void Checkout() {
            var myCart = DIContainer.GetModule<Cart>();
            myCart.CheckOut(45, 77);
        }
    }
}
