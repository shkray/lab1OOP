namespace FactoryMethodDesignPattern
{
    public class SberbankFactory: CreditCardFactory
    {
        protected override Creditcard MakeProduct()
        {
            Creditcard product = new Sberbank();
            return product;
        }
    }
}