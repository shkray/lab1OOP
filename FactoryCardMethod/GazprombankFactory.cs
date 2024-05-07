namespace FactoryMethodDesignPattern
{
    public class GazprombankFactory : CreditCardFactory
    {
        protected override Creditcard MakeProduct()
        {
            Creditcard product = new Gazprombank();
            return product;
        }
    }
}