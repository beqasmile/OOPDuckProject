using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.QuackBehaviorFolder
{
    public abstract class QuackBehavior
    {
        public QuackBehavior()
        {

        }
        public virtual void Quack()
        {
            Console.WriteLine("Simple QUE");
        }
    }
}
