using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodPattern.C_
{
    public  abstract class BaseGame
    {
        public void PlayGame()
        {
            Console.WriteLine("Jogando o nosso jogo ...");
            PlayFirstLevel();
            PlaySecondLevel();
            PlayThirdLevel();
        }
        public abstract void PlayFirstLevel();
        public abstract void PlaySecondLevel();
        public abstract void PlayThirdLevel();
    }
}
