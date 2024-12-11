using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxForEverything
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box1 = new Box<int>(123123);
            Console.WriteLine(box1);

            Box<string> box2 = new Box<string>("life in a box");
            Console.WriteLine(box2);
        }
    }
}
