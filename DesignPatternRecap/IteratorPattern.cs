using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class Iterator
    {
        public abstract object First();

        public abstract object Next();

        public abstract object CurrentItem();

        public abstract bool IsDone();

    }

    public class ConcreteIterator : Iterator
    {

        private ConcreteAggrate aggregate;
        private int current = 0;

        public ConcreteIterator(ConcreteAggrate aggregate)
        {
            this.aggregate = aggregate;
        }
        public override object CurrentItem()
        {
            return aggregate[current];
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override bool IsDone()
        {
            return current >= aggregate.Count - 1;
        }

        public override object Next()
        {
            return aggregate[++current];
        }
    }

    public abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    public class ConcreteAggrate : Aggregate
    {

        public IList<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return items.Count; }
        }

        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
