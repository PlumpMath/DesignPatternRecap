using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class AbstractClass
    {
        public abstract void PrimativeOperation1();

        public abstract void PrimativeOperation2();

        public void TemplateMethod()
        {
            PrimativeOperation1();
            PrimativeOperation2();
        }
    }

    public class ConcreteClassA : AbstractClass
    {
        public override void PrimativeOperation1()
        {
            Console.WriteLine("This is the action1 FROM class A");
        }

        public override void PrimativeOperation2()
        {
            Console.WriteLine("This is the action2 from class B");
        }
    }

    public class ConcreteClassB : AbstractClass
    {
        public override void PrimativeOperation1()
        {
            Console.WriteLine("This is the action1 FROM class B");
        }

        public override void PrimativeOperation2()
        {
            Console.WriteLine("This is the action1 FROM class B");
        }
    }
 
}
