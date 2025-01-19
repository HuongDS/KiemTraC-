using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_Test_1
{
    public class Inputter
    {
        public string InputString(string msg)
        {
            string output = "";
            do
            {
                Console.WriteLine(msg);
                output = Console.ReadLine();
                if (output.Length == 0) Console.WriteLine("Please input again: ");
            } while (output.Length == 0);
            return output;
        }

        public int InputInt(string msg)
        {
            bool fotmat = false;
            int output = 0;
            do
            {
                Console.WriteLine(msg);
                try
                {
                    output = int.Parse(Console.ReadLine());
                    fotmat = true;
                }
                catch
                {
                    Console.WriteLine("Input must be number!!!");
                }
            } while (!fotmat);
            return output;
        }

        public int InputIntInBound(string msg, int lowerBound, int upperBound)
        {
            bool isCont = true;
            int output;
            do
            {
                output = InputInt(msg);
                if (output >= lowerBound && output <= upperBound) isCont = false;
            }
            while (isCont);
            return output;
        }

        public int InputIntInBound(string msg, int lowerBound)
        {
            bool isCont = true;
            int output;
            do
            {
                output = InputInt(msg);
                if (output > lowerBound) isCont = false;
            }
            while (isCont);
            return output;
        }

        public decimal InputDec(string msg)
        {
            bool fotmat = false;
            decimal output = 0;
            do
            {
                Console.WriteLine(msg);
                try
                {
                    output = decimal.Parse(Console.ReadLine());
                    fotmat = true;
                }
                catch
                {
                    Console.WriteLine("Input must be number!!!");
                }
            } while (!fotmat);
            return output;
        }

        public decimal InputDecInBound(string msg, int lowerBound)
        {
            bool isCont = true;
            decimal output;
            do
            {
                output = InputDec(msg);
                if (output > lowerBound) isCont = false;
            }
            while (isCont);
            return output;
        }
    }
}
