using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State pattern");
            Context c = new Context(new ConcreteStatePlay());
            c.DoThis();
            c.DoThis();
        }
    }
}
