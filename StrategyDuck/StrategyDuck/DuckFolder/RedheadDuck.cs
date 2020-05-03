using StrategyDuck.FlyBehaviorFolder;
using StrategyDuck.QuackBehaviorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.DuckFolder
{
    public class RedheadDuck: Duck
    {
        public RedheadDuck(FlyBehavior flyBehavior, QuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Swim()
        {
            base.Swim();
            Console.WriteLine("Duck Swim");
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Redhead Display");
        }

        public override void PrintAllData()
        {
            Console.WriteLine("Print Red had data");
            Display();
        }
    }
}
