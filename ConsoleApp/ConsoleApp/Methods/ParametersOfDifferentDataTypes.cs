using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Methods
{
    public class ParametersOfDifferentDataTypes
    {
        public string DataTypes (int num, string name, bool condition)
        {
            string result = num + " is integer "+name+" is string "+condition+" is" +
                "boolean";
            return result;

        }
        public void viewDataTypes()
        {
            bool electricity = true;
            Console.WriteLine(DataTypes(123, "sameer", electricity ));
        }
    }
}
