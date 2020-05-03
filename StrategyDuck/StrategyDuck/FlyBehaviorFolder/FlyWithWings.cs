using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.FlyBehaviorFolder
{
    public class FlyWithWings : FlyBehavior
    {
        public override void Fly()
        {
            base.Fly();
            Console.WriteLine("Behavior Fly With Wing");
        }
    }
}
