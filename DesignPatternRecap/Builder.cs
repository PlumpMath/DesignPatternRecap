using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public abstract class Builder
    {
        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract void GetResult();

    }

    public class ConcretBuildA : Builder
    {
        public List<string> Result = new List<string>();
        public override void BuildPartA()
        {
            Result.Add("Building Part A");
        }

        public override void BuildPartB()
        {
            Result.Add("Building Part B");
        }

        public override void GetResult()
        {
            foreach (var item in Result)
            {
                Console.WriteLine(item);
            }
        }
    }

    public class Director
    {
        public void Construct(Builder b)
        {
            b.BuildPartA();
            b.BuildPartB();
        }
    }
}
