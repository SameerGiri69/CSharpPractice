using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Variables
{
    public class VariablesAndDataTypes
    {
        public int rollno;
        public float gpa;
        public bool passed;
        
        public void StudentInformation()
        {
            rollno = 12;
            string name = "sameer";
            gpa = 3.5f;
            passed = true;
            long LCno = 00200001656;
            Console.WriteLine("student name: " + name +  "lc no: " + LCno);
        }
        
       
    }
    public class Student
    {
        VariablesAndDataTypes mydata = new VariablesAndDataTypes();
        public void accessedInformation()
        {
            Console.WriteLine("rollno: " + mydata.rollno + "gpa: " + mydata.gpa + "pass/fail: " + mydata.passed);
        }
        
    }
}
