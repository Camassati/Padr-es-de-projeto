using System;

namespace SimUDuck2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zarro_americano zarro_Americano = new Zarro_americano();
            zarro_Americano.mensgem();

            Pato_de_borracha pato_De_Borracha = new Pato_de_borracha();
            pato_De_Borracha.mensgem();

            Pato_Real pato_Real = new Pato_Real();
            pato_Real.mensgem();

            Pato_Decoy pato_Decoy = new Pato_Decoy();
            pato_Decoy.mensgem();
        }
    }
}
