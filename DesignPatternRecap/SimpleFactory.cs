using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    class SimpleFactory
    {
        public static Operator CreateOperator(string operation)
        {
            switch (operation)
            {
                case "+":
                    return new OperatorAdd();
                case "-":
                    return new OperatorSub();
                default:
                    throw new NotSupportedException("Not supported");
            }
        }
    }

    public abstract class Operator
    {
        public string Operation { get; set; }

        public double NumberA { get; set; }

        public double NumberB { get; set; }

        public abstract double GetResult();
    }

    public class OperatorSub : Operator
    {
        public override double GetResult()
        {
            return NumberA - NumberB;
        }
    }

    public class OperatorAdd : Operator
    {
        public override double GetResult()
        {
            return NumberA + NumberB;
        }
    }

}
