using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
  internal class Quack : IQuackBehaviour
  {
    void IQuackBehaviour.Quack()
      => Console.WriteLine("Quack");
  }
}