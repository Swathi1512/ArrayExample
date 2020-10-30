using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Productdemo
    {
        static void Main()
        {
            //Product class explanation

            object ProductId;
            object ProductName;
            object Price;
            object Quantity;
            double Amountpayable;
            Console.Write("Enter the id of the product: ");
            ProductId = int.Parse(Console.ReadLine());
            Console.Write("Enter the name of the product: ");
            ProductName = Console.ReadLine();
            Console.Write("Enter Price: ");
            Price = int.Parse(Console.ReadLine());
            Console.Write("Enter Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Product Details:");
            int id = (int)ProductId;
            Console.Write("Product ID: "+id);
            string name = (string)ProductName;
            Console.Write("Product Name: "+name);
            int price = (int)Price;
            Console.Write("Price: "+price);
            int qty = (int)Quantity;
            Console.Write("Quantity: "+qty);
            Amountpayable = price * qty;
            Console.WriteLine("Amount Payable: "+Amountpayable);
            Console.ReadLine();
        }
    }
}
