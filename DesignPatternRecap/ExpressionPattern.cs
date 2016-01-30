using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public class ExpressionPattern
    {
        void Run()
        {
            InterpretContext ctx = new InterpretContext();
            IList<AbstractExpression> list = new List<AbstractExpression>();
            list.Add(new TerminalExpression());
            list.Add(new NonTerminalExpression());
            foreach (var item in list)
            {
                item.Interpret(ctx);
            }
            Console.Read();
        }
    }

    public class InterpretContext
    {
        public string Input { get; set; }

        public string Output { get; set; }
    }

    public abstract class AbstractExpression
    {
        public abstract void Interpret(InterpretContext ctx);
    }

    public class TerminalExpression : AbstractExpression
    {
        public override void Interpret(InterpretContext ctx)
        {
            Console.WriteLine("Terminal Interpretor is handling the {0},and the output is {1}", ctx.Input, ctx.Output);
        }
    }

    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(InterpretContext ctx)
        {
            Console.WriteLine("Non Terminal Interpretor is handling the {0},and the output is {1}", ctx.Input, ctx.Output);
        }
    }


}
