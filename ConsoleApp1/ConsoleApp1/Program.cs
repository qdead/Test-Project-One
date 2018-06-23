using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates an array with values already added.
            double[] doubleArray = { 1.05, 7, 1.3, 8, 9.65, 4, 9};
            //Creates an empty array.
            double[] newArray = new double[4];
            //Adds value to my empty array
            newArray[0] = 3;
            newArray[1] = 2.3;
            newArray[2] = 9.7;
            newArray[3] = 5.6;
            //For loop that loops through my array a specific amount of items.
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(newArray[i]);
            }
            //for loop that loops through all my item's-
            foreach (var item in doubleArray)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Test");
            Console.ReadKey();
        }
    }
}
