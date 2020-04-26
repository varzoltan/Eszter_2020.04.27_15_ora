using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._04._27_15_ora
{
    class Program
    {
        static void Main(string[] args)
        {
            char kar = 'b', kar1 = 'c';
            Console.WriteLine('\a');
            Console.Write(kar+kar1+"\t\f");
            Console.Write("szöveg!");
            Console.WriteLine('\b');
            Console.WriteLine('\u0066');
            Console.ReadKey();
        }
    }
}
