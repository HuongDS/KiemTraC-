using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class FruitManagement
    {
        List<Fruit> fruitList;
        public Inputter inputter = new Inputter();
        CustomerManagement customerManagement;
        OrderManagement orderManagement;

        public FruitManagement()
        {
            this.fruitList = new List<Fruit>();
            this.customerManagement = new CustomerManagement();
            this.orderManagement = new OrderManagement();
        }

        public void AddNewFruit()
        {
            int newID = fruitList.Count() + 1;
            string newName = inputter.InputString("Input New Name: ");
            decimal newPrice = inputter.InputDecInBound("Input price: ", 0);
            int quantity = inputter.InputIntInBound("Input quantity: ", 0);
            string origin = inputter.InputString("Input origin: ");
            fruitList.Add(new Fruit(newID, newName, newPrice, quantity, origin));
        }

        public void ViewOrders()
        {
            for (int i = 0; i < orderManagement.orders.Count(); i++)
            {
                Console.WriteLine("Customer: " + orderManagement.orders[i].CusName);
                Console.WriteLine("| ++ Item ++ | ++ Fruit Name ++ | ++ Price ++ |");
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine($"|     {orderManagement.orders[i].OID}      |     {orderManagement.orders[i].product,-12} |{orderManagement.orders[i].Total,-6} |");
                Console.WriteLine("Total: " + orderManagement.GetToTalByCusID(orderManagement.orders[i].CusID));
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void ShowAllFruits()
        {
            Console.WriteLine("--- MENU AHIHI ---");
            foreach (var fru in fruitList)
            {
                Console.WriteLine(fru);
            }
        }

        public Fruit FindeFruitByID(int id)
        {
            for (int i = 0; i < fruitList.Count(); i++)
            {
                if (fruitList[i].FID == id) return fruitList[i];
            }
            return null;
        }

        public void Shopping()
        {
            ShowAllFruits();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("_____ MAI DZO _____");
            int proID = inputter.InputIntInBound("Select: ", 0, fruitList.Count());
            Fruit fruitKey = FindeFruitByID(proID);
            Console.WriteLine("You Select: " + fruitKey.FName);
            int quantity = inputter.InputIntInBound("Please input quantity: ", 0);
            if (ConfirmMenu("Do you want to order now ? (Y/N)"))
            {
                Console.WriteLine(fruitKey);
                Console.WriteLine("Total: " + fruitKey.FPrice * quantity);
                Console.WriteLine();
                Console.WriteLine();
                string name = inputter.InputString("Input your name: ");
                int newCusID = customerManagement.list.Count() + 1;
                Order newOrder = new Order(orderManagement.orders.Count() + 1, newCusID, name, fruitKey.FName, fruitKey.FPrice * quantity);
                orderManagement.orders.Add(newOrder);
                if (!customerManagement.IsExist(newCusID))
                {
                    Customer newCus = new Customer(newCusID, name);
                    customerManagement.list.Add(newCus);
                }
            }
        }

        public bool ConfirmMenu(string msg)
        {
            return inputter.InputString(msg).ToUpper() == "Y";
        }
    }
}
