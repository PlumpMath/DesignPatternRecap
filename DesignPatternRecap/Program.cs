using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    class Program
    {
        static void Main(string[] args)
        {
            //ConcreteDecoratorA a = new ConcreteDecoratorA();
            //ConcreteDecoratorC c = new ConcreteDecoratorC();
            //ConcreteDecoratorB b = new ConcreteDecoratorB();

            //a.SetComponent(b);
            //b.SetComponent(c);

            //a.Operation();

            //Console.Read();

            //Student stu = new Student() { Name = "Jasper", Age = 25, Friend = new Friend { Name ="York" } };
            //var stu2 = stu.Clone();
            //((Student)stu2).Age = 18;
            //((Student)stu2).Friend.Name = "Sean";

            Work w = new Work(new ForenoonState());
            w.Hour = 15;
            w.WriteProgram();
            Console.Read();
        }
    }

    public class Friend
    {
        public string Name { get; set;}
    }

    class Student:ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Friend Friend { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
