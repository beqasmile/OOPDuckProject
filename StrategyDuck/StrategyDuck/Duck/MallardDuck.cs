using StrategyDuck.FlyBehaviorFolder;
using StrategyDuck.QuackBehaviorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.Duck
{
    public class MallardDuck: Duck
    {
        public MallardDuck(FlyBehavior flyBehavior, QuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Swim()
        {
            base.Swim();
            Console.WriteLine("Mallard Swim ");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Mallard Display");
        }
    }
}
