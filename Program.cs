using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
               
            foreach(char i in input)
            {
                if (i != 'h')
                {
                    Console.Write(i);
                }
                else
                {
                    break;
                }
            }

            foreach (char i in input.Reverse())
            {
                if (i != 'h')
                {
                    Console.Write(i);
                }
                else
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
