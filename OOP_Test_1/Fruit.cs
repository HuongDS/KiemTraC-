using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class Fruit
    {
        public int FID { get; set; }
        public string FName { get; set; }
        public decimal FPrice { get; set; }
        public int Quantity { get; set; }
        public string Origin { get; set; }

        public Fruit(int fID, string fName, decimal fPrice, int quantity, string origin)
        {
            FID = fID;
            FName = fName;
            FPrice = fPrice;
            Quantity = quantity;
            Origin = origin;
        }

        public override string? ToString()
        {
            return FID + "___" + FName + "___" + FPrice + "___" + Quantity;
        }
    }
}
