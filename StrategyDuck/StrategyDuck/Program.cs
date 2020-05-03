using StrategyDuck.Duck;
using StrategyDuck.FlyBehaviorFolder;
using StrategyDuck.QuackBehaviorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck
{
    class Program
    {
        static void Main(string[] args)
        {

            FlyNoWay flyNoWayBehavior = new FlyNoWay();
            Squeck squeck = new Squeck();

            DecoyDuck decoyDuck = new DecoyDuck(flyNoWayBehavior, squeck);
            decoyDuck.Fly();

            Console.ReadKey();
        }
    }
}
