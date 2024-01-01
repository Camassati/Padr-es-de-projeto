using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Channels;
using static Observer.C_Sharp.Program;

namespace Observer.C_Sharp
{
    public interface ISubject
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
    }
}
