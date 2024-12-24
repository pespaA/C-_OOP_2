using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common03
{
    internal class TypeB:TypeA
    {
        public int B { get; set; }
        public TypeB(int _A, int _B):base(_A)
        {
            B = _B;
        }
        public new void fun01()
        {
            Console.WriteLine(" I am Chiled [Derived]");
        }
        public override void fun02()
        {
            Console.WriteLine($"Type A is : A = {A}\nType B is : B = {B}");
        }
        public void Test01()
        {
            // X is inherted private 
            // Y is inherted private
            // Z is inherted internal

            //TypeA obj = new TypeA();
            //obj.X = 10;// X is Private
            //obj.Y = 10;// X is Private
            //obj.Z = 10;// X is internal

        }
    }
}
