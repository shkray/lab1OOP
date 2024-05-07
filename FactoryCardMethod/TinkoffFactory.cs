namespace FactoryMethodDesignPattern
{
    public class TinkoffFactory: CreditCardFactory
    {
        protected override Creditcard MakeProduct()
        {
            Creditcard product = new Tinkoff();
            return product;
        }
    }
}