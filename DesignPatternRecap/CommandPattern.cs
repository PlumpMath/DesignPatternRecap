using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    class CommandPattern
    {
    }

    public class Receiver
    {
        public Receiver()
        {

        }

        public void Action1()
        {
            Console.WriteLine("Do something 1!");
        }

        public void Action2()
        {
            Console.WriteLine("Do something 2");
        }
    }

    public abstract class Command
    {
        protected Receiver receiver;

        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

       public abstract void Excute();
       
    }


    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver):base(receiver)
        {

        }
        public override void Excute()
        {
            receiver.Action1();
        }
    }

    public class ConcreteCommand2 : Command
    {
        public ConcreteCommand2(Receiver receiver):base(receiver)
        {

        }
        public override void Excute()
        {
            receiver.Action2();
        }
    }

    public class Invoker
    {
        private Command command;
        public void SetCommand(Command cmd)
        {
            command = cmd;
        }

        public void Excute()
        {
            command.Excute();
        }
    }
}
