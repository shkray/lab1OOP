using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Zadanie1
{
    public class RationalNumber
    {
        private int Numerator;
        public int Denominator;

        public RationalNumber(int num, int denom)
        {
            if (denom == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            Numerator = num;
            Denominator = denom;
            Simplify();
        }
        private void Simplify()
        {
            int nok = NOD(Math.Abs(Numerator), Math.Abs(Denominator));
            Numerator /= nok;
            Denominator /= nok;
            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }

        private int NOD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public override string ToString()
        {
            if (Denominator == 1)
                return Numerator.ToString();
            else
                return $"{Numerator}/{Denominator}";
        }

     
        public static RationalNumber operator +(RationalNumber a, RationalNumber b) 
        { 
            int num = a.Numerator * b.Denominator + b.Numerator + a.Denominator;
            int denom = a.Denominator * b.Denominator;
            return new RationalNumber(num, denom);
        }

        public static RationalNumber operator -(RationalNumber a, RationalNumber b)
        {
            int num = a.Numerator * b.Denominator - b.Numerator + a.Denominator;
            int denom = a.Denominator * b.Denominator;
            return new RationalNumber(num, denom);
        }

        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            return a.Numerator == b.Numerator && b.Denominator == a.Denominator;
        }

        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.Numerator * b.Denominator > b.Numerator * a.Denominator;
        }

        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.Numerator * b.Denominator < b.Numerator * a.Denominator;
        }

    }                                                                                                       
}
    

    

