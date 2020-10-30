using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class arrQno3
    {
        static void main(string[] args)
        {
            //It is used to initialize an array and get the values

            string[] arr = new string[5];
            Console.WriteLine("Enter the city names: ");
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("The city names are:");
            foreach (string j in arr)
            {
                Console.WriteLine(j);
            }
            Console.ReadLine();
        }
    }
}
