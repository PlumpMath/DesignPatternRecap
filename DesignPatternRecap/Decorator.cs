using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class Component
    {
        public abstract void Operation();
    }

    public class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete Operation");
        }
    }

    public class Decorator : Component
    {
        protected Component component;

        public void SetComponent(Component comp)
        {
            component = comp;
        }
        public override void Operation()
        {
            if (component != null)
                component.Operation();
        }
    }

    public class ConcreteDecoratorA : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddMoreBehaviours();
        }

        private void AddMoreBehaviours()
        {
            Console.WriteLine("More Operations in Concrete Decorator A");
        }
    }

    public class ConcreteDecoratorB : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddMoreBehaviours();
        }

        private void AddMoreBehaviours()
        {
            Console.WriteLine("More Operations in Concrete Decorator B");
        }
    }


    public class ConcreteDecoratorC : Decorator
    {
        public override void Operation()
        {
            base.Operation();
            AddMoreBehaviours();
        }

        private void AddMoreBehaviours()
        {
            Console.WriteLine("More Operations in Concrete Decorator C");
        }
    }
}
