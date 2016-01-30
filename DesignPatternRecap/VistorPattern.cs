using System;
using System.Collections.Generic;

namespace DesignPatternRecap
{

    /// <summary>
    /// Vistor 算法可以随时演变
    /// </summary>
    class VistorPattern
    {

        void Run()
        {
            ObjectStructure o = new ObjectStructure();
            o.Attach(new ConcreteElementA());
            o.Attach(new ConcreteElementB());

            ConcreteVistor1 v1 = new ConcreteVistor1();
            ConcreteVistor2 v2 = new ConcreteVistor2();

            o.Accept(v1);
            o.Accept(v2);
        }
    }

    class ObjectStructure
    {
        private IList<Element> elements = new List<Element>();

        public void Attach(Element element)
        {
            elements.Add(element);
        }

        public void Dettach(Element element)
        {
            elements.Remove(element);
        }

        public void Accept(Vistor visitor)
        {
            foreach (var item in elements)
            {
                item.Accept(visitor);
            }
        }
    }

    abstract class Element
    {
        public abstract void Accept(Vistor visitor);
    }

    class ConcreteElementA : Element
    {
        public override void Accept(Vistor visitor)
        {
            visitor.VisitConcretElementA(this);
        }
    }

    class ConcreteElementB : Element
    {
        public override void Accept(Vistor visitor)
        {
            visitor.VisitConcretElementB(this);
        }
    }




    abstract class Vistor
    {
        public abstract void VisitConcretElementA(ConcreteElementA elementA);
        public abstract void VisitConcretElementB(ConcreteElementB elementB);
    }


    class ConcreteVistor1 : Vistor
    {
        public override void VisitConcretElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("元素{0}被{1}访问中....", elementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitConcretElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("元素{0}被{1}访问中....", elementB.GetType().Name, this.GetType().Name);
        }
    }


    class ConcreteVistor2 : Vistor
    {
        public override void VisitConcretElementA(ConcreteElementA elementA)
        {
            Console.WriteLine("元素{0}被{1}访问中....", elementA.GetType().Name, this.GetType().Name);
            //Anything else
        }

        public override void VisitConcretElementB(ConcreteElementB elementB)
        {
            Console.WriteLine("元素{0}被{1}访问中....", elementB.GetType().Name, this.GetType().Name);
            //Anything else
        }
    }

}
