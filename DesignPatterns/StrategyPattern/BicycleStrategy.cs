using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    class BicycleStrategy : IStrategy
    {
        public void Run()
        {
            Console.WriteLine("Soy una bici y pedalean para correr");
        }
    }
}
