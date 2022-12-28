using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck2._0
{
    public abstract class Pato
    {
        internal void VoarNaoSei()
        {
            Console.WriteLine("Voar: Não sei voar");
        }
        internal void VoarSei()
        {
            Console.WriteLine("Voar: To voando");
        }
        internal void Boiando()
        {
            Console.WriteLine("Boiar: Todos boiam\n");
        }
        internal void QuackSei()
        {
            Console.WriteLine("Som: Quack");
        }
        internal void QuackMudo()
        {
            Console.WriteLine("Som: --Silencio--");
        }
        internal void QuackRangido()
        {
            Console.WriteLine("Som: Rangido");
        }
        internal abstract void Display();
    }

}
