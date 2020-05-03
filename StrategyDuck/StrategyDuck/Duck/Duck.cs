using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck
{
    public class Duck
    {
        private FlyBehavior flyBehavior;
        private QuackBehavior quackBehavior;

        public virtual void Quack()
        {

        }

        public virtual void Swim()
        {

        }
        public virtual void Fly()
        {

        }

        public virtual void Display()
        {

        }
    }
}
