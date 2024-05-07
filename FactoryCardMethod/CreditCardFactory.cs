namespace FactoryMethodDesignPattern
{
    public abstract class CreditCardFactory
    {
        protected abstract Creditcard MakeProduct();
        public Creditcard CreateProduct()
        {
            Creditcard creditcard = this.MakeProduct();
            return creditcard;
        }
    }
}