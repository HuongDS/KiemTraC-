using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class Order
    {
        public int OID { get; set; }
        public int CusID { get; set; }
        public string CusName { get; set; }
        public string product { get; set; }
        public decimal Total { get; set; }

        public Order(int oID, int cusID, string CusName, string product, decimal total)
        {
            OID = oID;
            CusID = cusID;
            CusName = CusName;
            this.product = product;
            Total = total;
        }

    }
}
