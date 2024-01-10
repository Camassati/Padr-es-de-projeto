using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPattern.C_
{
    public class CompetitiveGame : BaseGame
    {
        public override void PlayFirstLevel()
        {
            Console.WriteLine("Jogando o primeiro nivel do nosso jogo competitivo");
        }

        public override void PlaySecondLevel()
        {
            Console.WriteLine("Jogando o segundo nivel do nosso jogo competitivo");
        }

        public override void PlayThirdLevel()
        {
            Console.WriteLine("Jogando o terceiro nivel do nosso jogo competitivo");
        }
    }
}
