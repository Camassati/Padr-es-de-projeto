using Decorator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class CebolaDecorator : PizzaDecorator
    {
       public CebolaDecorator(IPizza pizza) : base(pizza)
       {

       }
        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n com extra de cebola";
            return pizza;
        }
    }
}
