using System;
using System.Collections.Generic;

namespace ShopEf
{
    public class Order
    {
        public DateTime Date { get; set; }
        public Customer Customer { get; set; } 
        public IList<Product> Items { get; set; }
    }
}
