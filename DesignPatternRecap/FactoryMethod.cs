using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    interface IFactory
    {
        Operation CreateOperation();
    }

    public abstract class Operation
    {
        public double NumberA { get; set; }

        public double NumberB { get; set; }

        public abstract double GetResult();
       
    }

    public class AddOperation : Operation
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

    public class SubOperation : Operation
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }


    public class AddFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new AddOperation();
        }
    }

    public class SubFactory : IFactory
    {
        public Operation CreateOperation()
        {
            return new SubOperation();
        }
    }
}
