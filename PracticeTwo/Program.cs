using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("please enter a number ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("please enter another number ");
            int y = int.Parse(Console.ReadLine());

            int z = x + y;

            Console.Write("the sum of {0} and {1} equals {2}",x,y,z);
            Console.ReadKey();
        }
    }
}
