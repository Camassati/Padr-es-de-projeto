using FactoryMethod.ConcretePrroduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class BlackFactory : CartaoFactory
    {
        private int _limiteCredito;
        private int _cobrancaAnual;
        public BlackFactory(int limiteCredito, int cobrancaAnual)
        {
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override CartaoDeCredito BuscarCartaoDeCredito()
        {
            return new CartãoBlack(_limiteCredito, _cobrancaAnual);
        }
    }
}
