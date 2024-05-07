
using static Zadanie2.AMTIME;
using static Zadanie2.Decorator;
using static Zadanie2.EUTIME;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTimePrinter europeanTime = new EuropeanDateTimePrinter();
            DateTimePrinter americanTime = new AmericanDateTimePrinter();

            // Декорирование
            europeanTime = new CustomSymbolDecorator(europeanTime, "Nikita ", " Lunev");
            americanTime = new CustomSymbolDecorator(americanTime, "Nikita ", " Lunev");
            var decdec = new CustomSymbolDecorator(americanTime, "dfsd", "");
            // Вывод 
            Console.WriteLine("European style: " + europeanTime.GetCurrentDateTime());
            Console.WriteLine("American style: " + decdec.GetCurrentDateTime());
        }
    }
}
