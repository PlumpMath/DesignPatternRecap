using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class Strategy
    {
        public abstract void StrategyAgorithmInterface();
    }

    public class ConcretStrategyA : Strategy
    {
        public override void StrategyAgorithmInterface()
        {
            Console.WriteLine("Agorithm A");
        }
    }

    public class ConcretStrategyB : Strategy
    {
        public override void StrategyAgorithmInterface()
        {
            Console.WriteLine("Agorithm B");
        }
    }

    public class Context
    {
        Strategy strategy;
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void StrategyAgorithm()
        {
            strategy.StrategyAgorithmInterface();
        }
    }
}
