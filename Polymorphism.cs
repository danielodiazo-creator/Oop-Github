using Oop_Github;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Github
{
    public class Polymorphism   //Denna är huvudklassen
    {
        public virtual void PrintInfo()
        {
            Console.WriteLine("You are a poymorphism");
        }
    }

    public class Runner : Polymorphism //Denna är en Underklass som ärvar från Polymorphism
    {
        public override void PrintInfo()
        {
            Console.WriteLine("You are a runner"); //Gör lite ändringar i text
        }
    }

    public class Swimmer : Polymorphism // Underklass
    {
        public override void PrintInfo()
        {
            Console.WriteLine("You are a swimmer"); //Gör lite ändringar i text
        }
    }
    }

    public class Skater : Polymorphism // Underklass
    {
        public override void PrintInfo()
        {
            Console.WriteLine("You are a skater"); //Gör lite ändringar i text
    }
}
    }
}
