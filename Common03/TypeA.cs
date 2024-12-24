using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common03
{
    internal class TypeA
    {
        //private protected int X;// Private
        //protected int Y; // Private
        //internal protected int Z; // internal
        public int A { get; set; }

        public TypeA(int _A)
        {
            A = _A;
        }
        public void fun01()
        {
            Console.WriteLine("Iam Base [Parent]");
        }
        public virtual void fun02()
        {
            Console.WriteLine($"Type A is : A = {A}");
        }

    }
}
