using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Entities
{
    /// <summary>
    /// Besitzer von Flug-Verhalten einer Ente
    /// </summary>
    public interface IFlyBehaviour
    {
        /// <summary>
        /// Flug-Verhalten einer Ente
        /// </summary>
        public void Fly();
    }
}