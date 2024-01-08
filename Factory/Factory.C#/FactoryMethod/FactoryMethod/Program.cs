
using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

CartaoFactory cartaoFactory = null;
Console.WriteLine("Que tipo de cartão gostaria obter: ");
string console =  Console.ReadLine();
switch (console.ToLower())
{
    case "black":
        cartaoFactory = new BlackFactory(50000,0);
        break;

    case "titanium":
        cartaoFactory = new TitaniumFactory(100000, 500);
        break;

    case "platinum":
        cartaoFactory = new PlatinumFactory(500000, 1000);
        break;
}
CartaoDeCredito cartaoDeCredito = cartaoFactory.BuscarCartaoDeCredito();
Console.WriteLine("\nOs detalhes do seu cartão estão a baixo: \n");
Console.WriteLine("Tipo do cartão: {0}\nCrédito Limite: {1}\nCobrança Anual: {2}",
    cartaoDeCredito.TipoCartao, cartaoDeCredito.LimiteCredito, cartaoDeCredito.CobrancaAnual);
Console.ReadKey();
