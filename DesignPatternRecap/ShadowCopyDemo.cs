using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    class Program2
    {
        static void Main2(string[] args)
        {
            //ConcreteDecoratorA a = new ConcreteDecoratorA();
            //ConcreteDecoratorC c = new ConcreteDecoratorC();
            //ConcreteDecoratorB b = new ConcreteDecoratorB();

            //a.SetComponent(b);
            //b.SetComponent(c);

            //a.Operation();

            //Console.Read();

            Student stu = new Student() { Name = "Jasper", Age = 25, Friend = new Friend { Name = "York" } };
            var stu2 = stu.Clone();
            ((Student)stu2).Age = 18;
            ((Student)stu2).Friend.Name = "Sean";

        }
    }

}
