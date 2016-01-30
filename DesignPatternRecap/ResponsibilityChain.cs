using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    class ResponsibilityChain
    {
    }

    public abstract class Handler
    {
        protected Handler successor;

        public void SetSuccessor(Handler s)
        {
            this.successor = s;
        }

        public abstract void Handle(int request);
    }

    public class ConcreteHandler1 : Handler
    {
        public override void Handle(int request)
        {
            if (request > 0 && request < 10)
            {
                Console.Write("I can handle it!");
            }
            else {
                successor.Handle(request);
            }
        }
    }

    public class ConcreteHandler2 : Handler
    {
        public override void Handle(int request)
        {
            if (request > 10 && request < 20)
            {
                Console.Write("I can handle it!");
            }
            else
            {
                successor.Handle(request);
            }
        }
    }
}
