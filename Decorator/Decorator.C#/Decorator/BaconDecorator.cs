using Decorator.Interface;

namespace Decorator
{
    public class BaconDecorator : PizzaDecorator
    {
        public BaconDecorator(IPizza pizza) : base(pizza)
        {

        }

        public override string BuscarTipoPizza()
        {
            var pizza = base.BuscarTipoPizza();
            pizza += "\r\n Com extra de Bacon";
            ;
            return pizza;
        }
    }
}
