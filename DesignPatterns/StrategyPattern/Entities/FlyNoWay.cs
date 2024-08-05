﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
  internal class FlyNoWay : IFlyBehaviour
  {
    public void Fly()
      => Console.WriteLine("I can't fly.");
  }
}