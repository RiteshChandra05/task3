using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ovrrdng
{
     class program
    {
         public class person
         {
        public string FirstName = "FN";
        public string LastName = "LN";
        
        public virtual void Printnamae()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
        public class Teacher : person
        {
            public override void Printnamae()
            {
                Console.WriteLine(FirstName + " " + LastName + "tecaher");
            }
        }
    public class Student : person
    {
        public override void Printnamae()
        {
            Console.WriteLine(FirstName + " " + LastName + "student");
        }
    }
        static void Main(string[] args)
        {
            person[] persons = new person[3];
            persons[0] = new person();
            persons[1] = new Teacher();
            persons[2] = new Student();
            foreach(person p in persons)
            {
                p.Printnamae();
            }
        }
    }
}
