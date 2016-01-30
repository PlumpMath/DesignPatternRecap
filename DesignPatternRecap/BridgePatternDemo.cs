using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public class BridgePatternDemo
    {

    }


    public abstract class Abstraction
    {
        protected Implementor implementor;
        public abstract void SetImplementor(Implementor implementor);
        public abstract void Operation();
    }

    public class RefinedAbstraction : Abstraction
    {
        
        public override void SetImplementor(Implementor implementor)
        {
            this.implementor = implementor;
        }
        public override void Operation()
        {
            implementor.Operation();
        }
    }

    public abstract class Implementor
    {
        public abstract void Operation();
    }

    public class ConcretImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("This is the implementor of A");
        }
    }
}
