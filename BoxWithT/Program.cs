using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxWithT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();
            box.Add(12);
            box.Add(13);
            box.Add(19);
            Console.WriteLine(box.Remove());
            box.Add(8);
            box.Add(18);
            Console.WriteLine(box.Remove());
            
        }
    }
}
