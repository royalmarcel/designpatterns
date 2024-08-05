using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities.Internal
{
  /// <summary>
  /// Abstrakte Klasse für eine Ente
  /// </summary>
  /// <author>Marcel Lange</author>
  /// <remarks>
  /// In diesem Beispiel wird das Flugverhalten und Quackverhalten von Enten unter Verwendung der
  /// Komposition mit Interfaces flexibel gehalten. Es wird zentral an der Basisklasse definiert.
  /// Bei Änderungen müssen nur die Klassen für das explizit implementierte Verhalten angepasst werden.
  /// Bestehender Code ist flexibel erweiterbar, ohne das der bestehende Code in der Basis-Klasse angepasst werden muss.
  /// 
  /// ---------------------------------
  /// ---- Encapsulate what varies ----
  /// ---------------------------------
  /// Es gibt verschiedene Enten. Einige können z.B. fliegen und andere wiederum nicht.
  /// Enten können verschiedene Geräusche von sich geben (z.B. normale Enten, Quietscheente im Bad 
  /// oder eine Entenatrappe gibt keine Geräusche von sich).
  /// 
  /// Dinge die sich ändern müssen ausgelagert bzw. gekapselt werden, um den Quellcode flexibel,
  /// wartbar und einfach erweiterbar zu halten. Wie das Ziel erreicht wird, wird im nächsten Design Priciple erklärt :D
  /// 
  /// ---------------------------------------------
  /// ---- Favour Composition over Inheritance ----
  /// ---------------------------------------------
  /// + Durch Verwendung der Komposition ahand von Interfaces (Verträgen) bleibt Quellcode flexibel. (fördert Open-Closure Prinzip)
  /// + Verhalten wird während der Laufzeit festgelegt und kann ausgetauscht werden.
  /// + bietet zentrale Stelle zur Verwaltung der Verhaltensklassen aller Enten durch Implementierung in Basisklasse
  /// Allgemeines Problem bei Quellcode-Lösung mit Vererbung (also ohne Kompositionsansatz):
  /// - Verhalten wird zur Compilerzeit festgelegt und kann nicht geändert werden...
  /// - Es kann kein unterschiedliches Verhalten in der Basis für mehrere Enten definiert werden
  /// - Implementierung in konkreten Klassen fördert nicht die Austauschbarkeit + 1000 Tode bei Quellcode-Anpassung in z.B. 1000 Klassen :D
  /// 
  /// ---------------------------------------------------
  /// ---- Program to interfaces not implementations ----
  /// ---------------------------------------------------
  /// Dadurch das wir gegen ein Interface (kann auch Basisklasse sein) implementieren, müssen wir bei Quellcode-Anpassung 
  /// nur die Klasse für die konkrete Implementierung anpassen. Die Basisklasse bleibt von Veränderungen verschont.
  /// 
  /// </remarks>
  public abstract class DuckBase
    {
      // + Komposition ermöglicht für unterschiedliche Enten das FLugverhalten flexibel festzulegen
      // + Open Closure-Prinzip 
      // + Änderungen werden gekapselt und können separat angepasst werden
      private IFlyBehaviour flyBehaviour = default!; 
      private IQuackBehaviour quackBehaviour = default!;

      #region Constructor

      public DuckBase()
      {
        flyBehaviour = CreateFlyBehaviour(); 
        quackBehaviour = CreateQuackBehaviour();
      }

      #endregion

      #region Abstract Methods

      internal abstract void Display();

      // Erzeugung wird in Basisklasse über Schnittstelle gekapselt und in konkreter Klasse implementiert
      // Dadurch müssen wir bei der Intanziierung der konkreten Klasse kein Quellcode mitgeben, der später angepasst werden muss
      internal abstract IFlyBehaviour CreateFlyBehaviour();

      internal abstract IQuackBehaviour CreateQuackBehaviour();

      #endregion
      
      public void SetFly(IFlyBehaviour flyBehaviour)  // ermöglicht dynamische Änderung zur Laufzeit
        => this.flyBehaviour = flyBehaviour;

      public void SetQuack(IQuackBehaviour quackBehaviour) // ermöglicht dynamische Änderung zur Laufzeit
        => this.quackBehaviour = quackBehaviour;

      public void PerformFly()
        => flyBehaviour.Fly();

      public void PerformQuack()
        => quackBehaviour.Quack();  
    }
}