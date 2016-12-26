using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bxng
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = 55;
            object box = Num;// boxing
            Console.WriteLine(box + " " + Num);
            int unbox = (int)box;//unboxing
            Console.WriteLine(box + " " + unbox);
        }
    }
}
