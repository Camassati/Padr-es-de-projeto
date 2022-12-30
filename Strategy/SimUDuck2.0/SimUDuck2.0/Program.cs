using System;

namespace SimUDuck2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IPatoStrategy pato = new Zarro_americano();
            pato.Quack();
            pato.ComportamentoVoo();

            pato = new Pato_Decoy();
            pato.Quack();
            pato.ComportamentoVoo();

            pato = new Pato_Real();
            pato.Quack();
            pato.ComportamentoVoo();


        }
    }
}
