using StrategyPattern.Entities.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    /// <summary>
    /// Lockvogel-Ente
    /// </summary>
    /// <author>Marcel Lange</author>
    public class DecoyDuck : DuckBase
    {
      internal override IFlyBehaviour CreateFlyBehaviour() 
        => new FlyNoWay();

      internal override IQuackBehaviour CreateQuackBehaviour()
        => new MuteQuack();

      internal override void Display()
        => Console.WriteLine("I am not a real duck. I am a Decoy duck.");
    }
}
