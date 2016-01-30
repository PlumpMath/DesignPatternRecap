using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternRecap
{
    public class Singleton
    {
        public static readonly object syncObject = new object();

        public static Singleton instance;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (syncObject)
                {
                    if (instance == null)
                        instance = new Singleton();
                }

            }

            return instance;
        }
    }


    public sealed class SingletonOfCsharp
    {
        private static readonly SingletonOfCsharp instance = new SingletonOfCsharp();
        private SingletonOfCsharp()
        {

        }

        public static SingletonOfCsharp GetInstance()
        {
            return instance;
        }
    }
}
