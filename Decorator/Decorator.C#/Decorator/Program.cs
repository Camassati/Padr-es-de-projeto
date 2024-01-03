
using Decorator;
using Decorator.Interface;

IPizza pizza = new Pizza();
IPizza quejoDecorator = new QueijoDecorator(pizza);
Console.WriteLine(quejoDecorator.BuscarTipoPizza());
Console.WriteLine();

