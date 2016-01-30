using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    class MediatorPattern
    {
    }

    /// <summary>
    /// 中介模式
    /// </summary>
    public abstract class Mediator
    {
        public abstract void SendMessage(Colleague from, string message);
    }

    public class ConcretMediator:Mediator
    {
        public ConcreteColleague1 collegue1 { get; set; }

        public ConcreteColleague2 collegue2 { get; set; }

        public override void SendMessage(Colleague from, string message)
        {
            if (from is ConcreteColleague1)
            {
                collegue2.Receive(message);
            }
            if (from is ConcreteColleague2)
            {
                collegue1.Receive(message);
            }
        }
    }

    public abstract class Colleague
    {
        protected Mediator mediator;

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }

    public class ConcreteColleague1 : Colleague
    {

        private Mediator mediator;

        public ConcreteColleague1(Mediator m) : base(m)
        {

        }

        public void SetMediator(Mediator m)
        {
            mediator = m;
        }

        public void Send(string message)
        {
            mediator.SendMessage(this, message);
        }

        public void Receive(string message)
        {
            Console.WriteLine("收到消息：{0}", message);
        }
    }

    public class ConcreteColleague2 : Colleague
    {

        private Mediator mediator;

        public ConcreteColleague2(Mediator m)
            : base(m)
        {

        }

        public void SetMediator(Mediator m)
        {
            mediator = m;
        }

        public void Send(string message)
        {
            mediator.SendMessage(this, message);
        }

        public void Receive(string message)
        {
            Console.WriteLine("收到消息：{0}", message);
        }
    }
}
