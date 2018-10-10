using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = new int[] { 10, 20, 30, 40, 60 };
            int[] secondArray = new int[] { 10, 20, 30, 40, 50 };
            Array firstArrayClass = new Array(firstArray);
            Array secondArrayClass = new Array(secondArray);

            Console.WriteLine(firstArrayClass > secondArrayClass);
            Console.WriteLine(firstArrayClass < secondArrayClass);
            Console.Read();

        }
    }
}
