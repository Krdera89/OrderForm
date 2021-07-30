using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderForm1
{
    public class Product:IComparable
    {
       public string ProductName;
       public double ProductPrice;
       public string ProductDescription;

        public int Quantity;



        public int CompareTo(object obj)
        {
            return ProductName.CompareTo(obj);
        }
    }
}
