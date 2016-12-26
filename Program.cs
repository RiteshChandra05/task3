using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hasttbl
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h1 = new Hashtable();
            h1[1] = "one";
            h1[2] = "two";
            h1[3] = "three";

            foreach (DictionaryEntry e in h1)
            {
                Console.WriteLine(e.Key + " " + e.Value);

            }

        }
    }
}
