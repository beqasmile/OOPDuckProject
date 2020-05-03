using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.FlyBehaviorFolder
{
    public class FlyNoWay : FlyBehavior
    {

        public FlyNoWay() : base()
        {
           
        }
        public override void Fly()
        {
            base.Fly();
        }
    }
}
