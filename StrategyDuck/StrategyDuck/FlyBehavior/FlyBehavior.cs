using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck
{
    public class FlyBehavior
    {
        public virtual void Fly()
        {
            Console.WriteLine("Simple Fly");
        }
    }
}
