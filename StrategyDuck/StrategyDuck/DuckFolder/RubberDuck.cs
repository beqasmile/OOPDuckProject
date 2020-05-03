using StrategyDuck.FlyBehaviorFolder;
using StrategyDuck.QuackBehaviorFolder;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.DuckFolder
{
    public class RubberDuck:Duck
    {
        public RubberDuck(FlyBehavior flyBehavior, QuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {
        }

        public override void Swim()
        {
            base.Swim();
            Console.WriteLine("Rubber Swim");
        }
        public override void Display( )
        {
            base.Display();
            Console.WriteLine("Rubber Display");
        }

        public override void PrintAllData()
        {
            base.Display();

            Console.WriteLine("Print All Datea Rubber");
        }
    }
}
