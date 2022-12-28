using System;

namespace SimUDuck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zarro_americano zarro_Americano = new Zarro_americano();
            zarro_Americano.mensagem();
         

            Pato_real pato_real = new Pato_real();
            pato_real.mensagem();

            Pato_de_borracha pato_De_Borracha = new Pato_de_borracha();
            pato_De_Borracha.mensagem();

        }
    }
}
