using StrategyDuck.FlyBehaviorFolder;
using StrategyDuck.QuackBehaviorFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDuck.DuckFolder
{
    public abstract class Duck
    {
        private FlyBehavior flyBehavior;
        private QuackBehavior quackBehavior;

        public FlyBehavior FlyBehavior { get => flyBehavior; set => flyBehavior = value; }
        public QuackBehavior QuackBehavior { get => quackBehavior; set => quackBehavior = value; }

        public Duck (FlyBehavior flyBehavior, QuackBehavior quackBehavior)
        {
            this.FlyBehavior = flyBehavior;
            this.QuackBehavior = quackBehavior;
        }

        public virtual void Quack()
        {
            Console.WriteLine("Duck Quack with " );
            this.quackBehavior.Quack();

        }
        public abstract void PrintAllData();

        public virtual void Swim()
        {

        }
        public virtual void Fly()
        {
            Console.WriteLine("Duck fly with ");
            this.flyBehavior.Fly();
        }

        public virtual void Display()
        {

        }
    }
}
