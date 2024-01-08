using CommandPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CommandPattern
{
    internal class Receiver : IReceiver<Command, IState>
    {

        public IState Handle(Command command)
        {
            command.Execute();
            return new State(200, "Comando executado com sucesso");
        }
    }
}
