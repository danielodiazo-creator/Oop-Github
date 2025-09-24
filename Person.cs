using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Github
{
    public class Person
    {
        public string name;
        public string aftername;
        public int age;
        public int id;
        

        public void PrintInfo()
        {
            Console.WriteLine("Ditt namn är " + name + " Ditt efternamn är " + aftername +
                " Ditt ålder är " + age + "Ditt id är " + id);
        }
    }

}
