using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Tuple
{
    public class TupleExample
    {
        public (string, int) Information()
        {
            var name = "samuel";
            var age = 44;
            return(name, age);

        }
        public void displayInfo()
        {
            Console.WriteLine(Information());
        }
    }
}
