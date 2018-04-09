using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programming_course
{
    public class MiniDuckSimulator
    {

        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();

            WildTurkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The turkey says..");
            turkey.gobble();
            turkey.fly();

            Console.Read();
        }


    }
}
