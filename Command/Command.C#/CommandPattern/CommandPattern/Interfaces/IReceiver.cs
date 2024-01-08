using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern.Interfaces
{
    internal interface IReceiver<in T, out O> 
    where T : ICommand
    where O : IState
    {
        IState Handle(T command);
    }
}
