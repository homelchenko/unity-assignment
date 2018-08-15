using System;

namespace Fractions
{
    public struct Fraction : IEquatable<Fraction>
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction(int numerator) : this(numerator, 1)
        {
        }

        public static Fraction operator + (Fraction left, Fraction right)
        { 
            return new Fraction(left._numerator);
        }

        public static implicit operator Fraction(int value)
        {
            return new Fraction(value);
        }

        public override bool Equals(object value)
        {
            if (!(value is Fraction))
            {
                return false;
            }

            Fraction other = (Fraction)value;

            return Equals(other);
        }

        public override int GetHashCode()
        {
            return 11 + 7 * _numerator.GetHashCode()
                   + 7  * _denominator.GetHashCode();
        }

        public bool Equals(Fraction other)
        {
            return _numerator == other._numerator
                   && _denominator == other._denominator;
        }

        public static bool operator == (Fraction left, Fraction right)
        {
            return Object.Equals(left, right);
        }

        public static bool operator != (Fraction left, Fraction right)
        {
            return !Object.Equals(left, right);
        }

    }   
}
