using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Constructors
{
    public class CreatingConstructors
    {
        int age;
        string address;
        string name;
        string wifeName;
        public CreatingConstructors()
        {
             age = 34;
             address = "harpic land";
             name = "harpic";
             wifeName = "toilet";
        }
        public void Details()
        {
            Console.WriteLine("his name is: " + name + " he is: " + age+ " years old" +
                " his wife name is " + wifeName + " and he is from " + address);

        }
    }
}
