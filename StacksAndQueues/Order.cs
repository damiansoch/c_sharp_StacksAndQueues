using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StacksAndQueues
{
    public class Order
    {
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }
        public Order(int orderId, int orderQuality)
        {
            OrderId = orderId;
            OrderQuantity = orderQuality;
        }

        public void ProcessOrder()
        {
            Console.WriteLine($"Order {OrderId} processed");
        }
    }

}
