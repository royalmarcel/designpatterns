using StrategyPattern.Entities.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    public class MallardDuck : DuckBase
    {
      internal override IFlyBehaviour CreateFlyBehaviour()
        => new FlyWithWings();
      internal override IQuackBehaviour CreateQuackBehaviour()
        => new Quack();

      internal override void Display()
            => Console.WriteLine("I am a real Mallard duck.");
    }
}
