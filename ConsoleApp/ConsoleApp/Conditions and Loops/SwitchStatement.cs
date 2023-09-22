using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Conditions_and_Loops
{
    public class SwitchStatement
    {
        public void SwitchStatements() 
        {
            Console.WriteLine("Enter number corresponding to the day (eg: 1 for sunday");
            int num = Convert.ToInt32(Console.ReadLine());
            switch(num)
            {
                case 1:
                    Console.WriteLine("sunday");
                    break;
                case 2:
                    Console.WriteLine("monday");
                    break;
                case 3:
                    Console.WriteLine("tuesday");
                        break;
                case 4:
                    Console.WriteLine("wednesday");
                    break;
                case 5:
                    Console.WriteLine("thursday");
                    break;      
            }
        }
    }
}
