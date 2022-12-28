using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    internal class Pato_real : Ave , iComportamentoDoBarulho , iComportamentoVoar
    { 
       
        public override void Display()
        {
            Console.Write("Aparece um pato-real");
        }

        public void comportamentoDoBarulho()
        {
            Console.WriteLine("Quack");
        }

        public void comportamentoVoar()
        {
            Console.WriteLine("Voando");
        }
        public void mensagem()
        {
            Display();
            Console.WriteLine();
            Boiar();
            comportamentoDoBarulho();
            comportamentoVoar();
            Console.WriteLine();
        }
    }
}
