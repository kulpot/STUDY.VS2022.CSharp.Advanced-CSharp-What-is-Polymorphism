using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace What_is_Polymorphism
{
    class Employee : Person
    {
        public string ID { get; set; }

        public void IntroduceSelf()
        {
            //Console.WriteLine("Hello my name is " + Name + " and my id is " + ID);
            Console.WriteLine($"Hello my name is {Name}, I am {Age} years old and my id is {ID}");
        }
    }
}
