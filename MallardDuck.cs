using System;

namespace programming_course
{

    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            Quack QuackBehavior = new Quack();
            FlyWithWings FlyBehavior = new FlyWithWings();
        }
    }
}
