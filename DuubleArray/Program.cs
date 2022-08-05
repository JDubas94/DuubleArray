using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuubleArray
{
    class Program
    {
        static int[] DubleArray(int[] array)
        {
            int[] newArray = new int[array.Length];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i] * 2;

            }
            return newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 2, 4, 6, };

            int[] array3 = DubleArray(myArray);

            for (int i = 0; i < array3.Length; i++)
            {
                Console.WriteLine(array3[i]);
            }


            Console.ReadLine();

        }

    }
}
