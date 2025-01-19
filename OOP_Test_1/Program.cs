using OOP_Test_1;

class Program
{
    public static void Main(string[] args)
    {
        FruitService service = new FruitService();
        int choice;
        do
        {
            choice = service.ShowMenuAndGetChoice();
            switch (choice)
            {
                case 1:
                    {
                        bool isCont;
                        do
                        {
                            isCont = service.CreateProduct();
                        } while (isCont);
                        break;
                    }
                case 2:
                    {
                        service.ViewOrders();
                        break;
                    }
                case 3:
                    {
                        service.Shopping();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("BYEEE");
                        return;
                    }
            }
        }
        while (choice != 4);
    }

}