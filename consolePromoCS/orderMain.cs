using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionCS;

namespace Avengers
{
    class MainFunc
    {
        static void Main(string[] args)
        {
            OrderInput a = new OrderInput();
            
            //wg disc ** b = new b();
            
            a.initiateOrderAdd();
            Order userOrder = a.returnOrder();
        }
    }
}
