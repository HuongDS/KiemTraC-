using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class FruitService
    {
        FruitManagement manager = new FruitManagement();

        public int ShowMenuAndGetChoice()
        {
            Console.WriteLine("FRUIT SHOP SYSTEM");
            Console.WriteLine("1. Create Fruit");
            Console.WriteLine("2. View Orders");
            Console.WriteLine("3. Shopping (for buyer)");
            Console.WriteLine("4. Exit");
            return manager.inputter.InputIntInBound("Please select an option (1-4): ", 1, 4);
        }

        public bool CreateProduct()
        {
            manager.AddNewFruit();
            Console.WriteLine("Successful");
            return manager.ConfirmMenu("Do you want to continue (Y/N)?");
        }

        public void ViewOrders()
        {
            manager.ViewOrders();
        }

        public void Shopping()
        {
            manager.Shopping();
        }
    }
}
