using System;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace FactoryMethodDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("What amount are you interested in:\n");
                int balance = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine("Which bank card are you interested in:\n1)Sberbank\n2)Tinkoff\n3)Gazprombank");
                int quary = int.Parse(Console.ReadLine());
                switch (quary)
                {
                    case 1:
                        Console.Clear();
                        Creditcard creditCard = new SberbankFactory().CreateProduct();
                        int limit = new Sberbank().CardLimit;
                        double commission = new Sberbank().CardCommission;
                        if (creditCard != null && balance <= limit)
                        {
                            Console.WriteLine("Card Type : " + creditCard.GetCardType());
                            Console.WriteLine("Credit Limit : " + creditCard.GetCardLimit() + "Rub");
                            Console.WriteLine("Card Commission :" + creditCard.GetCardCommission());
                            Console.WriteLine("--------------");
                            Console.WriteLine("You will be pay: " + (commission * balance + balance) + "Rub");
                        }
                        else
                        {
                            Console.Write("Your amount exceeds the limit");
                        }
                        Console.WriteLine("--------------");
                        break;
                    case 2:
                        Console.Clear();
                        Creditcard creditCard2 = new TinkoffFactory().CreateProduct();
                        int limit2 = new Tinkoff().CardLimit;
                        double commission2 = new Tinkoff().CardComission;
                        if (creditCard2 != null && balance <= limit2)
                        {
                            Console.WriteLine("Card Type : " + creditCard2.GetCardType());
                            Console.WriteLine("Credit Limit : " + creditCard2.GetCardLimit() + "Rub");
                            Console.WriteLine("Card Commission :" + creditCard2.GetCardCommission());
                            Console.WriteLine("--------------");
                            Console.WriteLine("You will be pay: " + (commission2 * balance + balance) + "Rub");
                        }
                        else
                        {
                            Console.Write("Your amount exceeds the limit");
                        }
                        Console.WriteLine("--------------");
                        break;
                    case 3:
                        Console.Clear();
                        Creditcard creditCard3 = new GazprombankFactory().CreateProduct();
                        int limit3 = new Gazprombank().CardLimit;
                        double commission3 = new Gazprombank().CardCommission;
                        if (creditCard3 != null && balance <= limit3)
                        {
                            Console.WriteLine("Card Type : " + creditCard3.GetCardType());
                            Console.WriteLine("Credit Limit : " + creditCard3.GetCardLimit() + "Rub");
                            Console.WriteLine("Card Commission :" + creditCard3.GetCardCommission());
                            Console.WriteLine("--------------");
                            Console.WriteLine("You will be pay: " + (commission3 * balance + balance) + "Rub");
                        }
                        else
                        {
                            Console.Write("Your amount exceeds the limit\nTry new amount or other bank");
                        }
                        Console.WriteLine("--------------");

                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Wrong number");
                        break;
                }
            }
            
        }
    }
}
