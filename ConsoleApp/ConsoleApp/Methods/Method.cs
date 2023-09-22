using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp.Methods
{
    public class Method
    {
        //parameterized methods
        public int Addition(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public void Result()
        {
            int result = Addition(23, 55);
            Console.WriteLine(result);
        }
        public string StudentInformation(string name, string address, string ID)
        { 
           string info = "The student's name is " + name + " Address: " + address +" And ID number: " + ID;
            return info;
            
        }
        public void ShowStudentInformation()
        {
            string information =StudentInformation("milan", "surunga", "69");
            Console.WriteLine(information);
        }
        public int Temperature(int f)
        {
            int c = (f - 32) * 5 / 9;
            return c;
        }
        public void displayTemperature()
        {
            int result = Temperature(100);
            Console.WriteLine("the temp in c is: "+result);
        }
        public int ArrayAddition(int[] expenses)
        {
            int sum = 0;
            foreach ( var item in expenses )
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
