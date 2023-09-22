using ConsoleApp.Variables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Methods
{
    public class MethodOverloading
    {
        //using same method names multiple times but with different parameters
        public string Information(int a, int b)
        {
            int sum = a + b;
            string info = "the total sum is : " + sum;
            return info;
        }
        public string Information(string name, string address)
        {
            string info = "the name is: " + name + " and their address is : " + address;
            return info;
        }
        public void viewInformaiton()
        {
            Console.WriteLine(Information(1, 2));
            Console.WriteLine(Information("sameer", "jamunkhadi"));
        }
    }
}
