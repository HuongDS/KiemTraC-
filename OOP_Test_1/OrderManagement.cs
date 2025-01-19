using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class OrderManagement
    {
        public List<Order> orders;

        public OrderManagement()
        {
            this.orders = new List<Order>();
        }

        public decimal GetToTalByCusID(int CusID)
        {
            return orders.Where(x => x.CusID == CusID).Sum(x => x.Total);
        }
    }
}
