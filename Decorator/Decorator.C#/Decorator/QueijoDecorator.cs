using Decorator.Interface;

namespace Decorator
{
    //Concrete Decorator
    public class QueijoDecorator : PizzaDecorator
    {
        public QueijoDecorator(IPizza pizza) : base(pizza)
        {
            
        }
        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n Com extra de queijo";
;
            return pizza;
        }
    }
}
