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
            mallard.setFlyBehavior(new FlyWithWings());
            mallard.setQuackBehavior(new Quack());
            mallard.performQuack();
            mallard.performFly();

            Console.Read();
        }


    }
}
