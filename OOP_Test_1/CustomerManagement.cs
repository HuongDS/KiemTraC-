using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class CustomerManagement
    {
        public List<Customer> list;

        public CustomerManagement()
        {
            this.list = new List<Customer>();
        }

        public int FindCusByName(string name)
        {
            return list.FirstOrDefault(cus => cus.CusName.ToUpper() == name.ToUpper()) == null ? list.Count() + 1 : list.FirstOrDefault(cus => cus.CusName.ToUpper() == name.ToUpper()).CusID;
        }

        public bool IsExist(int id)
        {
            foreach (var cus in list)
            {
                if (cus.CusID == id) return true;
            }
            return false;
        }
    }
}
