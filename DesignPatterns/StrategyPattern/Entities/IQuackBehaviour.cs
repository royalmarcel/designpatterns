using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    /// <summary>
    /// Besitzer von Quack-Verhalten einer Ente
    /// </summary>
    /// <author>Marcel Lange</author>
    public interface IQuackBehaviour
    {
        /// <summary>
        /// Quack-Verhalten einer Ente
        /// </summary>
        public void Quack();
    }
}