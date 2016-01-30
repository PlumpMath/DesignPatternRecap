using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{

    public abstract class ComponentObject
    {
        protected string name;

        public ComponentObject(string name)
        {
            this.name = name;
        }
        public abstract void Add(ComponentObject c);
        public abstract void Remove(ComponentObject c);
        public abstract void Display(int Depth);
    }

    public class Composite : ComponentObject
    {
        public List<ComponentObject> childItems = new List<ComponentObject>();

        public Composite(string name)
            : base(name)
        {

        }

        public override void Add(ComponentObject c)
        {
            childItems.Add(c);
        }

        public override void Display(int Depth)
        {
            Console.Write(new string('-', Depth) + name);
            foreach (var item in childItems)
            {
                item.Display(Depth + 1);
            }
        }

        public override void Remove(ComponentObject c)
        {
            childItems.Remove(c);
        }
    }

    public class Leaf : ComponentObject
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(ComponentObject c)
        {
            throw new NotImplementedException();
        }

        public override void Display(int Depth)
        {
            Console.Write(new string('-', Depth) + name);
        }

        public override void Remove(ComponentObject c)
        {
            throw new NotImplementedException();
        }
    }

}
