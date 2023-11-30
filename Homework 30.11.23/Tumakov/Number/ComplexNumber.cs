using System;

namespace Tumakov
{
    internal class ComplexNumber
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }

        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }


        public static ComplexNumber operator +(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.Real + c2.Real;
            double imaginary = c1.Imaginary + c2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }


        public static ComplexNumber operator -(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.Real - c2.Real;
            double imaginary = c1.Imaginary - c2.Imaginary;
            return new ComplexNumber(real, imaginary);
        }


        public static ComplexNumber operator *(ComplexNumber c1, ComplexNumber c2)
        {
            double real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary;
            double imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real;
            return new ComplexNumber(real, imaginary);
        }


        public static bool operator ==(ComplexNumber c1, ComplexNumber c2)
        {
            return c1.Real == c2.Real && c1.Imaginary == c2.Imaginary;
        }


        public static bool operator !=(ComplexNumber c1, ComplexNumber c2)
        {
            return !(c1 == c2);
        }


        public override string ToString()
        {
            string sign = Imaginary >= 0 ? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }
    }
}