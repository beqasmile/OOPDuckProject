using StrategyDuck.FlyBehaviorFolder;
using StrategyDuck.QuackBehaviorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.DuckFolder
{
    public class DecoyDuck:Duck
    {
        public DecoyDuck(FlyBehavior flyBehavior, QuackBehavior quackBehavior) : base(flyBehavior, quackBehavior)
        {

        }
       

        public override void Swim()
        {
            base.Swim();
            Console.WriteLine("Decow Swim" );
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Decoy Display");
        }

        public override void PrintAllData()
        {
            Console.WriteLine("Decoy");
            Display();
        }
    }
}
