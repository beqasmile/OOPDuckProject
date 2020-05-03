using StrategyDuck.FlyBehaviorFolder;
using StrategyDuck.QuackBehaviorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyDuck;
using StrategyDuck.DuckFolder;

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


            FlyWithWings flyWithWings = new FlyWithWings();
            QuackBehavior quackBehavior = new MuteDuck();

            Duck duckMallard = new MallardDuck(flyWithWings, quackBehavior);

            List<Duck> listDuck = new List<Duck>();

            listDuck.Add(decoyDuck);
            listDuck.Add(duckMallard);

            Console.ReadKey();
        }
    }
}
