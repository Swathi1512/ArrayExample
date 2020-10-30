using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class arrQno2
    {
        static void main()
        {
            int[,] marr = new int[5, 6];
            Console.WriteLine("Enter the array elements: ");
            for(int i=0;i<marr.GetLength(0);i++)
            {
                for(int j=0;j<marr.GetLength(1);j++)
                {
                    marr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The array elements are: ");
            foreach(int arr in marr)
            {
                Console.WriteLine(arr);
            }
            Console.ReadLine();
        }
    }
}
