using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = new Singleton();
            Singleton obj2 = new Singleton();
            if (obj1 == obj2)
            {
                Console.WriteLine("obj1とobj2は同じインスタンスです。");
            }
            else
            {
                Console.WriteLine("obj1とobj2は同じインスタンスではありません。");
            }
        }
    }
}
