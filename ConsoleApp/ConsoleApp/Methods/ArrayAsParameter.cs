using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Methods
{
    public class ArrayAsParameter
    {
        public int ArrayAddition(int[] expenses)
        {
            int sum = 0;
            foreach (var item in expenses)
            {
                sum += item;

            }
            return sum;
        }
        public void displayArrayAddition()
        {
            int[] expenses = { 1000, 2000, 6585, 8945 };
            int result = ArrayAddition(expenses);
            Console.WriteLine(result);
        }
    }
}
