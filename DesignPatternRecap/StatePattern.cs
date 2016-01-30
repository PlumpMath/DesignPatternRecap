using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class State
    {
        public abstract void WriteProgram(Work w);
    }

    public class Work
    {
        private State currentState;

        public Work(State s)
        {
            currentState = s;
        }

        public double Hour { get; set;}

        public bool TaskFinished { get; set; }

        public void SetState(State s)
        {
            currentState = s;
        }

        public void WriteProgram()
        {
            currentState.WriteProgram(this);
        }

        internal void SetState(object nooState)
        {
            throw new NotImplementedException();
        }
    }

    class ForenoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 12)
                Console.WriteLine(string.Format("当前上午时间 {0} 点", w.Hour));
            else
            { 
                w.SetState(new NooState());
                w.WriteProgram();
            }
        }
    }

    class NooState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 13)
            {
                Console.WriteLine("当前时间：{0} 点，饿了，困了，午休");
            }
            else
            {
                w.SetState(new AfterNoonState());
                w.WriteProgram();
            }
        }
    }

    class AfterNoonState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.Hour < 17)
            {
                Console.WriteLine("当前时间:{0}，下午工作状态还可以，继续努力", w.Hour);
            }
            else
            {
                w.SetState(new EveningState());
                w.WriteProgram();
            }
        }
    }


    class EveningState : State
    {
        public override void WriteProgram(Work w)
        {
            if (w.TaskFinished)
            {
                w.SetState(new RestState());
                w.WriteProgram();
            }
            else
            {
                if (w.Hour < 21)
                {
                    Console.WriteLine("当前时间:{0}，疲累之极", w.Hour);
                }
                else
                {
                    w.SetState(new SleepingState());
                    w.WriteProgram();
                }
            }

           
        }
    }

    class RestState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间:{0}，下班了", w.Hour);
        }
    }

    class SleepingState : State
    {
        public override void WriteProgram(Work w)
        {
            Console.WriteLine("当前时间:{0}，需要休息了", w.Hour);
        }

    }

}
