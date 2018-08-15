using System;

namespace Fractions
{
    public struct Fraction : IEquatable<Fraction>
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator must not be zero");
            }

            if (denominator < 0)
            { 
                _numerator = -numerator;
                _denominator = -denominator;
            }
            else
            {
                _numerator = numerator;
                _denominator = denominator;
            }
        }

        public Fraction(int numerator) : this(numerator, 1)
        {
        }

        public static Fraction operator + (Fraction left, Fraction right)
        {
            int lcm = CalculateLcm(left._denominator, right._denominator);
            
            Fraction likeLeft = left.BuildEquivalent(lcm);
            Fraction likeRight = right.BuildEquivalent(lcm);

            int numerator = likeLeft._numerator + likeRight._numerator;

            var result = new Fraction(numerator, likeLeft._denominator);
            
            return result.Reduce();
        }

        private static int CalculateLcm(int left, int right)
        {
            return left * right / CalculateGcd(left, right);
        }

        private Fraction BuildEquivalent(int lcm)
        {
            int numerator = lcm / _denominator * _numerator;

            return new Fraction(numerator, lcm);
        }

        private Fraction Reduce()
        {
            int gcd = CalculateGcd(_numerator, _denominator);

            return new Fraction(_numerator / gcd, _denominator / gcd);
        }

        private static int CalculateGcd(int left, int right)
        {
            int remainder = left % right;

            if (remainder == 0)
            {
                return right;
            }

            return CalculateGcd(right, remainder);
        }

        public static Fraction operator - (Fraction left, Fraction right)
        {
            int lcm = CalculateLcm(left._denominator, right._denominator);
            
            Fraction likeLeft = left.BuildEquivalent(lcm);
            Fraction likeRight = right.BuildEquivalent(lcm);

            int numerator = likeLeft._numerator - likeRight._numerator;

            return new Fraction(numerator, likeLeft._denominator);
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

        public override string ToString()
        {
            if (_denominator == 1)
            {
                return $"{_numerator}";
            }

            if (_numerator == 0)
            {
                return "0";
            }

            return $"{_numerator} / {_denominator}";
        }
    }   
}
