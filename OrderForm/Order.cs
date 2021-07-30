using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderForm1
{
    
    public class Order
    {
        public List<Product> Prods = new List<Product>();

        public double Total
        { 
            get
            { double ReturnTotal = 0;
                foreach(Product P in Prods)//This goes through each product in the list
                {
                    ReturnTotal+=P.ProductPrice*P.Quantity;//Accesses product price and adds return total from the list
                    
                } return ReturnTotal;
            }

        }

    }
}
