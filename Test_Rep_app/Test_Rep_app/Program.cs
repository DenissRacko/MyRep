using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test_Rep_app
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            string s;
            Console.WriteLine("Ievadiet x:");
            s = Console.ReadLine(); x = int.Parse(s);
            Console.WriteLine("Ievadiet y:");
            s = Console.ReadLine(); y = int.Parse(s);
            z = x * y;            
            Console.ReadLine();
        }
    }
}
