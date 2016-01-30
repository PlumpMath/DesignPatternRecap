using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{


    public abstract class Subject
    {
        public abstract void Request();
    }

    public class Proxy : Subject
    {

        protected Subject underlyingSubject;


        public override void Request()
        {
            if (underlyingSubject == null)
                underlyingSubject = new RealSubject();
            underlyingSubject.Request();
        }
    }

    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("I am requesting something!");
        }
    }

}
