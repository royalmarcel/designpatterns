﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
  public class FlyWithWings : IFlyBehaviour
  {
    public void Fly()
      => Console.WriteLine("I'm flying.");
  }
}