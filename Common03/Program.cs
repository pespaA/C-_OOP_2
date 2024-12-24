namespace Common03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TypeA typeA = new TypeA(5);
            typeA.A = 5;
            typeA.fun01();
            typeA.fun02();
            TypeB typeB = new TypeB(3,4);
            typeB.A = 10;
            typeB.B = 20;
            typeB.fun01();
            typeB.fun02();


        }
    }
}
