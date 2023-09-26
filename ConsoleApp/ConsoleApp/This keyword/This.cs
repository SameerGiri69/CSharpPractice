using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.This_keyword
{
    public class This
    {
        double pi = 3.14;
        public void PI()
        {
            double pi = 0;
            Console.WriteLine("enter radius");
            int radius = Convert.ToInt32(Console.ReadLine());
            double area = this.pi * radius * radius;
            Console.WriteLine(area);
        }
    }
}
