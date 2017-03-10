using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PromotionCS;

namespace Avengers
{
    class OrderInput
    {
        private Order totalOrder = new Order();

        public Order returnOrder()
        {
            return totalOrder;
        }


        public void initiateOrderAdd()
        {
            bool contFlag = true;
            while (contFlag)
            {
                try
                {
                    Console.WriteLine("Enter Name of product: ");
                    string prodName = Console.ReadLine();


                    Console.WriteLine("Enter quantity of product: ");
                    int qty = Convert.ToInt16(Console.ReadLine());

                    //totalOrder.Add(ProductCatalog.GetProduct(prodName), qty);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                bool validYN = false;

                while (!validYN)
                {
                    Console.WriteLine("Add next item?(Y or N): ");
                    string a = Console.ReadLine();
                    if (a.ToUpper() == "Y")
                    {
                        contFlag = true;
                        validYN = true;
                    }
                    else if (a.ToUpper() == "N")
                    {
                        contFlag = false;
                        validYN = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input, Please enter Y or N to continue.");
                    }
                }
            }
        }
    }
    
}
