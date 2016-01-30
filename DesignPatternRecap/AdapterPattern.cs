using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("普通请求");
        }
    }

    public class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("特殊请求");
        }
    }

    public class Adatper : Target
    {
        public Adaptee adaptee = new Adaptee();

        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}
