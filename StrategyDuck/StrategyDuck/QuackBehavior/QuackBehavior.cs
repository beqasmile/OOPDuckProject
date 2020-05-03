using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck
{
    public class QuackBehavior
    {
        public virtual void Quack()
        {
            Console.WriteLine("Simple Quack");
        }
    }
}
