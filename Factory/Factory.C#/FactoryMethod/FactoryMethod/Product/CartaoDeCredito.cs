namespace FactoryMethod.Product
{
    public abstract class CartaoDeCredito
    {
        public  abstract string TipoCartao { get;}
        public abstract int LimiteCredito { get; set; }

        public abstract int CobrancaAnual { get; set; }
    }
}
