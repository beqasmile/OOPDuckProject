using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.QuackBehaviorFolder
{
    public class MuteDuck : QuackBehavior
    {

        public MuteDuck() : base()
        {

        }
        public override void Quack()
        {
            base.Quack();

        }
    }
}
