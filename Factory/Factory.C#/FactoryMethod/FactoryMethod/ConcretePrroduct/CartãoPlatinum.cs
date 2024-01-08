using FactoryMethod.Product;

namespace FactoryMethod.ConcretePrroduct
{
    public class CartãoPlatinum : CartaoDeCredito
    {
        private readonly string _tipoCartao;
        private int _limiteCredito;
        private int _cobrancaAnual;
        public CartãoPlatinum(int limiteCredito, int cobrancaAnual)
        {
            this._tipoCartao = "Platinum";
            this._limiteCredito = limiteCredito;
            this._cobrancaAnual = cobrancaAnual;
        }

        public override string TipoCartao
        {
            get { return _tipoCartao; }
        }
        public override int LimiteCredito
        {
            get { return _limiteCredito; }
            set { _limiteCredito = value; }
        }
        public override int CobrancaAnual
        {
            get { return _cobrancaAnual; }
            set { _cobrancaAnual = value; }
        }
    }
}
