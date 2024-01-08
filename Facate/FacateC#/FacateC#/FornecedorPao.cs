using FacateC_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacateC_
{
    public class FornecedorPao : IPao
    {
        public void BuscarPaoDeAlho()
        {
            Console.WriteLine("Obtendo pão de alho");
        }

        public void BuscarPaoDeAlhoComQueijo()
        {
            ObterQueijo();
            Console.WriteLine("Obtendo pão de alho com queijo.");
        }
        private void ObterQueijo() 
        {
            Console.WriteLine("Obtendo Queijo");
        }
       
    
    }
}
