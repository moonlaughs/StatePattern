using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class Context
    {
        private IState state;

        public Context(IState s)
        {
            ChangeState(s);
        }

        public void ChangeState(IState myState)
        {
            state = myState;
            state.SetContext(this);
        }

        public void DoThis()
        {
            state.DoThis();
        }

        //public void Stop()
        //{
        //    state.Stop();
        //}
    }
}
