// See https://aka.ms/new-console-template for more information
using StrategyPattern.Entities;

Console.WriteLine("Strategy-Beispiel: Verhalten von Enten :D");

MallardDuck mallardDuck = new MallardDuck();
DecoyDuck decoyDuck = new DecoyDuck();

Console.WriteLine("Mallard Duck:");
mallardDuck.Display();
mallardDuck.PerformQuack();
mallardDuck.PerformFly();

Console.WriteLine("Decoy Duck:");
decoyDuck.Display();
decoyDuck.PerformQuack();
decoyDuck.PerformFly();

Console.WriteLine("Decoy Duck kann fliegen:");
decoyDuck.SetFly(new FlyWithWings());
decoyDuck.PerformFly();

Console.WriteLine("Taste zum Beenden drücken.");
Console.ReadKey();