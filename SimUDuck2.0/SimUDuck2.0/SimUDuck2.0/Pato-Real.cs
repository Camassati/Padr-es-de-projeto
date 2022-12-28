using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck2._0
{
    internal class Pato_Real : Pato , iQuack, iComportamentoVoo 
    {
        public void Quack()
        {
            QuackSei();
        }
        public void ComportamentoVoo()
        {
            VoarSei();
        }
        internal override void Display()
        {
            Console.WriteLine("Aparece um pato com a cabeça vermelha");
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
