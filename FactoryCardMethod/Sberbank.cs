namespace FactoryMethodDesignPattern
{
    public class Sberbank:Creditcard
    {
        public int CardLimit = 100000;
        public double CardCommission = 0.2;
        public string GetCardType()
        {
            return "Sberbank";
        }
        public int GetCardLimit()
        {
            return 100000;
        }
        public string GetCardCommission()
        {
            
            return "20%";
        }
    }
}

