using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.QuackBehaviorFolder
{
    public sealed class Squeack :QuackBehavior
    {
        public Squeack() : base()
        {

        }
        public override void Quack()
        {
            base.Quack();
        }
    }
}
