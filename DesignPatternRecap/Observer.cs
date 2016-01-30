using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class SubjectToObserver
    {

        public List<Observer> Observers = new List<Observer>();
       

        public void Attach(Observer observer)
        {
            Observers.Add(observer);
        }

        public void Dettach(Observer observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in Observers)
            {
                item.Update();
            }
        }
    }

    public class ConcretSubjectA : SubjectToObserver
    {
        public string SubjectState { get; set; }
       
    }


    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcretObserverA : Observer
    {
        ConcretSubjectA subject;
        string observer_name;
        public ConcretObserverA(ConcretSubjectA sub, string name)
        {
            subject = sub;
            observer_name = name;
        }

        public override void Update()
        {
            Console.WriteLine(string.Format("{0}的状态是{1}", observer_name, subject.SubjectState));
        }
    }
}
