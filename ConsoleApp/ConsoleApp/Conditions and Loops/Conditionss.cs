using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Conditions_and_Loops
{
    internal class Conditionss
    {
        public void Conditions() 
        {
            Console.WriteLine("enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            if(age <18)
            {
                Console.WriteLine("you are not an adult");
            }

            else
            {
                Console.WriteLine("you are an adult");
            }
        }
    }
}
