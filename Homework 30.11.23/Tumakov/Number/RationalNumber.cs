using System;


namespace Tumakov
{
    internal class RationalNumber
    {
        private int numerator;
        private int denominator;


        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю.");
            }

            this.numerator = numerator;
            this.denominator = denominator;
            Simplify();
        }


        private void Simplify()
        {
            int gcd = GCD(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;


            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }


        private int GCD(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

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
            return numerator + "/" + denominator;
        }


        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            if (object.ReferenceEquals(r1, r2))
            {
                return true;
            }

            if (r1 is null || r2 is null)
            {
                return false;
            }

            return r1.numerator == r2.numerator && r1.denominator == r2.denominator;
        }


        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 == r2);
        }


        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) < (r2.numerator * r1.denominator);
        }


        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) > (r2.numerator * r1.denominator);
        }


        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) <= (r2.numerator * r1.denominator);
        }


        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return (r1.numerator * r2.denominator) >= (r2.numerator * r1.denominator);
        }


        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            int numerator = (r1.numerator * r2.denominator) + (r2.numerator * r1.denominator);
            int denominator = r1.denominator * r2.denominator;
            return new RationalNumber(numerator, denominator);
        }


        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            int numerator = (r1.numerator * r2.denominator) - (r2.numerator * r1.denominator);
            int denominator = r1.denominator * r2.denominator;
            return new RationalNumber(numerator, denominator);
        }


        public static RationalNumber operator ++(RationalNumber r)
        {
            return r + new RationalNumber(1, 1);
        }


        public static RationalNumber operator --(RationalNumber r)
        {
            return r - new RationalNumber(1, 1);
        }


        public static explicit operator float(RationalNumber r)
        {
            return (float)r.numerator / r.denominator;
        }

        public static explicit operator int(RationalNumber r)
        {
            return r.numerator / r.denominator;
        }


        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            int numerator = r1.numerator * r2.numerator;
            int denominator = r1.denominator * r2.denominator;
            return new RationalNumber(numerator, denominator);
        }


        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            int numerator = r1.numerator * r2.denominator;
            int denominator = r1.denominator * r2.numerator;

            if (denominator == 0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }

            return new RationalNumber(numerator, denominator);
        }


        public static RationalNumber operator %(RationalNumber r1, RationalNumber r2)
        {
            int numerator = (r1.numerator * r2.denominator) % (r2.numerator * r1.denominator);
            int denominator = r1.denominator * r2.denominator;

            if (denominator == 0)
            {
                throw new DivideByZeroException("Деление на ноль.");
            }

            return new RationalNumber(numerator, denominator);
        }
    }
}