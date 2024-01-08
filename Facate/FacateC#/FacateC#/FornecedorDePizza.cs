using FacateC_.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacateC_
{
    internal class FornecedorDePizza : IPizza
    {
        public void BuscarPizzaNormal()
        {
            ObterCoberturaNaoVegana();
            Console.WriteLine("Buscando Pizza normal");
        }

        public void BuscarPizzaVegana()
        {
            Console.WriteLine("Buscando pizza vegana");
        }
        private void ObterCoberturaNaoVegana()
        {
            Console.WriteLine("Obtendo coberturas de pizza não vegetais");
        }
    }
}
