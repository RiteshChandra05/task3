using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovrldng
{

    class test
    {
        static void Typeone(int x, int y)
        {
            Console.WriteLine("both are integers");
        }
        static void Typeone(int x, float y)
        {
            Console.WriteLine("one integer and one float");
        }

        static void Main(string[] args)
        {

            Typeone(1, 2);
        }
    }
}
