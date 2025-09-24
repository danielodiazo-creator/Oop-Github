using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_Github
{
    public abstract class Abstraktion
    {

        public abstract void Score();
    }

    public class Competiror : Abstraktion
    {
       public override void Score()
        {
            Console.WriteLine("Your score is 100/100"); 
        }
    }

}
