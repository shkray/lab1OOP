
namespace Zadanie1
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Creating Rational Numbers:\n");
            RationalNumber rational1 = new RationalNumber(3, 4);
            RationalNumber rational2 = new RationalNumber(1, 2);

            Console.WriteLine("First Rational Number: " + rational1);
            Console.WriteLine("Second Rational Number: " + rational2);

            Console.WriteLine("Operations:\n");
            RationalNumber sum = rational1 + rational2;
            RationalNumber raznost = rational1 - rational2;
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Raznost: " +  raznost);

            Console.WriteLine("Check equals: " + (rational1 == rational2));
            Console.WriteLine("Check not equals: " + (rational1!=rational2));
            Console.WriteLine("Check Is greater rational1 than rational2: " + (rational1 > rational2));
            Console.WriteLine("Check Is less rational1 than rational2 : " + (rational1 == rational2));
        }
    }
}