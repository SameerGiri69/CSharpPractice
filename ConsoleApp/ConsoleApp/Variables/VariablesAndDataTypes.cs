using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Variables
{
    public class VariablesAndDataTypes
    {
        public int a;
        string name;
        
        public void StudentInformation()
        {
            a = 12;
            name = "sameer";
            float gpa = 3.5f;
            bool passed = true;
            long LCno = 00200001656;
        }
       
    }
    public class Student
    {
        VariablesAndDataTypes mydata = new VariablesAndDataTypes();
        public void accessedInformation()
        {
            Console.WriteLine(mydata.StudentInformation);
        }
        
    }
}
