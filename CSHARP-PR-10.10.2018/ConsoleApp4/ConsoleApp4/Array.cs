using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Array
    {
        public int[] Numbers { get; set; }

        public Array(int[] numbers)
        {
            Numbers = numbers;
        }

        public static bool operator >(Array firstArray, Array secondArray) {
            return firstArray.Numbers.Sum() > secondArray.Numbers.Sum();
        }
        public static bool operator <(Array firstArray, Array secondArray)
        {
            return firstArray.Numbers.Sum() < secondArray.Numbers.Sum();
        }
    }
}
