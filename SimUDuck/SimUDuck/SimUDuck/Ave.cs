using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{
    public abstract class Ave
    {
       
        public virtual void Boiar()
        {
            Console.WriteLine("Boiando");
        }
       
        public abstract void Display();
    }
}
