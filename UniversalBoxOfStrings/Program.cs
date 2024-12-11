using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalBoxOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter count of strings:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter string: {i + 1}");
                string text = Console.ReadLine();
                Box<string> box = new Box<string>(text);

                Console.WriteLine(box);
            }
        }
    }
}
