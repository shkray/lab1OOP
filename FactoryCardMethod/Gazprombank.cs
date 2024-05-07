namespace FactoryMethodDesignPattern
{
    public class Gazprombank : Creditcard
    {
        public int CardLimit = 10000;
        public double CardCommission = 0.1;
        public string GetCardType()
        {
            return "Gazprombank";
        }
        public int GetCardLimit()
        {
            return 10000;
        }
        public string GetCardCommission()
        {
            return "10%";
        }
    }
}