using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class Flyweight
    {
        public abstract void Operation(int extrinsicstate);
    }

    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            throw new NotImplementedException();
        }
    }

    public class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            throw new NotImplementedException();
        }
    }

    public class FlyweightFactory
    {
        public Hashtable flyweights = new Hashtable();

        public FlyweightFactory()
        {
            flyweights.Add("X", new ConcreteFlyweight());
            flyweights.Add("Y", new UnsharedConcreteFlyweight());
            flyweights.Add("Z", new ConcreteFlyweight());
        }

        public Flyweight GetFlyweight(string key)
        {
            return (Flyweight)(flyweights[key]);
        }
    }
}
