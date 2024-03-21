using System;

namespace Class_Fraction
{
    public class Fraction : FractionBase
    {
        private int numerator;
        private int denominator;

        public Fraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            int newNumerator = (fraction1.numerator * fraction2.denominator) + (fraction2.numerator * fraction1.denominator);
            int newDenominator = fraction1.denominator * fraction2.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            int newNumerator = (fraction1.numerator * fraction2.denominator) - (fraction2.numerator * fraction1.denominator);
            int newDenominator = fraction1.denominator * fraction2.denominator;
            return new Fraction(newNumerator, newDenominator);
        }

        public static Fraction operator *(Fraction fraction, int multiplier)
        {
            int newNumerator = fraction.numerator * multiplier;
            return new Fraction(newNumerator, fraction.denominator);
        }

        public static Fraction operator *(int multiplier, Fraction fraction)
        {
            return fraction * multiplier;
        }

        public static Fraction operator /(Fraction fraction, int divisor)
        {
            int newDenominator = fraction.denominator * divisor;
            return new Fraction(fraction.numerator, newDenominator);
        }

        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {
            if (ReferenceEquals(fraction1, fraction2))
                return true;

            if (ReferenceEquals(fraction1, null) || ReferenceEquals(fraction2, null))
                return false;

            return fraction1.numerator * fraction2.denominator == fraction1.denominator * fraction2.numerator;
        }

        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            return !(fraction1 == fraction2);
        }

        public static bool operator true(Fraction fraction)
        {
            return fraction.numerator < fraction.denominator;
        }

        public static bool operator false(Fraction fraction)
        {
            return fraction.numerator >= fraction.denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (ReferenceEquals(obj, null))
            {
                return false;
            }

            throw new NotImplementedException();
        }
    }


    class Program
    {
        Fraction f = new Fraction(3, 4);
        int a = 10;
        Fraction f1 = f * a;
        Fraction f2 = a * f;
        double d = 1.5;
        Fraction f3 = f + d;

        Console.WriteLine(f1); // output: 30/4
        Console.WriteLine(f2); // output: 30/4
        Console.WriteLine(f3); // output: 12/4
        
    }
}