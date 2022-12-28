using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    internal class Pato_de_borracha : Ave, iComportamentoDoBarulho, iComportamentoVoar
    {
        public override void Display()
        {
            Console.Write("Aparece um pato de borracha");
        }

        public void comportamentoDoBarulho()
        {
            Console.WriteLine("Ringir");
        }

        public void comportamentoVoar()
        {
            Console.WriteLine("Não posso voar");
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
