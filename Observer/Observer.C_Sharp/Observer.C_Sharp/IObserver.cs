using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.C_Sharp
{
    public interface IObserver
    {
        void Update(ISubject s);

    }
}
