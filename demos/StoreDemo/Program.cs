using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] billing = new string[4];
            float shirtQty;
            float subTotal;
            float grandTotal;

            Console.WriteLine("Hello, and welcome to the store! \nWe are sorry but due to an ongoing shortage we only have T-shirts available.\n");

            //name prompt
            Console.Write("Please enter your name: ");
            billing[0] = Convert.ToString(Console.ReadLine());

            //address prompt
            Console.Write("Please enter your street address: ");
            billing[1] = Convert.ToString(Console.ReadLine());

            //state prompt
            Console.Write("Please enter your city and state: ");
            billing[2] = Convert.ToString(Console.ReadLine());

            //zip code prompt
            Console.Write("Please enter your zip code: ");
            billing[3] = Convert.ToString(Console.ReadLine());


            //shirt qty
            Console.Write("\nPlease enter the number of T-shirts you're entering: ");
            shirtQty = Convert.ToSingle(Console.ReadLine());


            //calculate pricing
            subTotal = 20 * shirtQty;
            grandTotal = (Convert.ToSingle(0.04225) * subTotal) + subTotal;


            //print receipt
            Console.Clear();
            Console.WriteLine("RECEIPT:\n");

            //billing info
            foreach (string s in billing)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            //qty of shirts ordered
            Console.WriteLine("QTY: " + shirtQty);

            //pricing
            Console.WriteLine("-----------" +
                $"\nSubtotal: {subTotal:C}" +
                $"\nTax rate: 4.225%" +
                $"\nGrand total: {grandTotal:C}\n" +
                $"\nThank you for shopping :)");

        }
    }
}
