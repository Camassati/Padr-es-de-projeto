using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck2._0
{
    internal class Pato_Decoy : Pato,iQuack,iComportamentoVoo
    {
        public void Quack()
        {
            QuackMudo();
        }
        public void ComportamentoVoo()
        {
            VoarNaoSei();
        }
        internal override void Display()
        {
            Console.WriteLine("Um pato de madeira");
        }
        public void mensgem()
        {
            Display();
            ComportamentoVoo();
            Quack();
            Boiando();
        }
    }
}
