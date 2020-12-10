using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class ConcreteStatePlay : IState
    {
        public override void DoThis()
        {
            this._context.ChangeState(new ConcreteStateStop());
            Console.WriteLine("playing...");
        }

        //public override void Stop()
        //{
        //    Console.WriteLine("concrete stop handles requests");
        //}
    }
}
