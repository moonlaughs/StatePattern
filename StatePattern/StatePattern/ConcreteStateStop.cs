using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class ConcreteStateStop: IState
    {
        public override void DoThis()
        {
            this._context.ChangeState(new ConcreteStatePlay());
            Console.WriteLine("stopped.");
        }

        //public override void Stop()
        //{
        //    Console.WriteLine("stopped.");
        //}
    }
}