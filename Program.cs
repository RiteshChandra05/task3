using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proctd
{
     class customer
    {
        private int num = 10;
         public void ShowMessage()
        {
            Console.WriteLine("Private Variable num not accessible");
        }
        public string s = "Hello";
        protected int Id=1001230;
    }
     class cccustomer : customer
    {
       public void show()
         {
             Console.WriteLine("Protected variable :" + Id);
         }
    }
    class Program
    {
           
        static void Main(string[] args)
        {
            customer c2 = new customer();
            cccustomer c3 = new cccustomer();
            //Console.WriteLine(c2.num); num is not accessible since it is private
            Console.WriteLine("Public variable: " + c2.s);
            c3.show();
            c2.ShowMessage();
            
        }
    }
}
