using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck2._0
{
    internal class Pato_de_borracha : Pato, IPatoStrategy
    {
        public void Quack()
        {
            QuackRangido();
        }
        public void ComportamentoVoo()
        {
            VoarNaoSei();
        }
        internal override void Display()
        {
            Console.WriteLine("Um pato de borracha");
        }
        
    }
}
