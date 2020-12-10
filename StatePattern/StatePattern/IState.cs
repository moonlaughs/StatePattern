using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    abstract class IState
    {
        protected Context _context;

        public void SetContext(Context context)
        {
            this._context = context;
        }
        public abstract void DoThis();
        //public abstract void Stop();
    }
}
