namespace FactoryMethodDesignPattern
{
    public class Tinkoff:Creditcard
    {
        public int CardLimit = 500000;
        public double CardComission = 0.05;
        public string GetCardType()
        {
            return "Tinkoff";
        }
        public int GetCardLimit()
        {
            
            return 500000;
        }
        public string GetCardCommission()
        {
            
            return "5%";
        }
    }
}