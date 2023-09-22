using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp.Conditions_and_Loops
{
    public class For_Loop
    {
        public void loop()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("This line is repeated "+ i +" times");
            }
        }
        public void multiplication()
        {
            for(int i = 0; i <= 10; i++)
            {
                int num = 7;
                int ans = num * i;
                Console.WriteLine(ans);
            }
        }
        public void starPattern()
        {
            for(int i = 0; i < 10;)
            {
                for (int j = 0; j< i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                i++;
            }
        }
        public void fibonacci()
        {
            int first = 0;
            int second = 1;

            for (int i = 0; i < 10; i++)
            {
                int next = first + second;
                Console.WriteLine(next);

                first = second;
                second = next;
            }
        }
    }
}
