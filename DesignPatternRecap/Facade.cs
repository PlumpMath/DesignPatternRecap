using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    /// <summary>
    /// 外观模式：为子系统中的一组接口提供一个一致的界面，此模式定义了一个高层接口，这一个接口使得子系统更加容易使用
    /// 在维护一个大型的遗留系统的时候，可以引入一个Facade类，让新系统与Facade对象交互，Facade与遗留系统交互所有复杂的工作
    /// </summary>

    public class Facade
    {
        SubSystemA SA = new SubSystemA();
        SubSystemB SB = new SubSystemB();
        public void Method1()
        {
            SA.Method1();
            SB.Method2();
        }

        public void Method2()
        {
            SA.Method2();
            SB.Method1();
        }
    }

    public class SubSystemA
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 in SubSystem A");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2 in SubSystem A");
        }
    }

    public class SubSystemB
    {
        public void Method1()
        {
            Console.WriteLine("Method 1 in SubSystem B");
        }

        public void Method2()
        {
            Console.WriteLine("Method 1 in SubSystem B");
        }
    }
}
