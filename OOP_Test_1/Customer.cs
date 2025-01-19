using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class Customer
    {
        public int CusID { get; set; }
        public string CusName { get; set; }

        public Customer(int cusID, string cusName)
        {
            CusID = cusID;
            CusName = cusName;
        }
    }
}
