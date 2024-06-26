using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lab08.Utility
{
    public class Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        #region Ctor
        public Fraction(int numerator = 1, int denominator = 1)
        {
            if (denominator == 0)
                Console.WriteLine("Can't Divide By Zero");
            Numerator = numerator;
            Denominator = denominator;
            Simplify();
        }
        #endregion

        #region Operators Overloading
        public static Fraction operator +(Fraction l, Fraction r) => new Fraction(l.Numerator * r.Denominator + r.Numerator * l.Denominator, l.Denominator * r.Denominator);
        public static Fraction operator +(Fraction l, int r) => new Fraction(l.Numerator + r * l.Denominator, l.Denominator);
        public static Fraction operator +(int l, Fraction r) => r + l;
        public static Fraction operator ++(Fraction f) => f + 1;
        public static bool operator ==(Fraction l, Fraction r) => l.Numerator == r.Numerator && l.Denominator == r.Denominator;
        public static bool operator !=(Fraction l, Fraction r) => !(l == r);

        #endregion

        #region Static Simplify For Test
        public static Fraction Simplify(int numerator, int denominator)
        {
            Fraction simplified = new Fraction(numerator, denominator);
            simplified.Simplify();
            return simplified;
        }
        #endregion

        #region Simplify
        private void Simplify()
        {
            int gcd = GCD(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;

            if (Denominator < 0)
            {
                Numerator = -Numerator;
                Denominator = -Denominator;
            }
        }
        #endregion

        #region Greatest Common Divisor
        private static int GCD(int a, int b)
        {

            a = Math.Abs(a);
            b = Math.Abs(b);

            int gcd;
            int min = Math.Min(a, b);
            int max = Math.Max(a, b);

            while (min != 0)
            {
                int remainder = max % min;
                max = min;
                min = remainder;
            }

            gcd = max;

            return gcd;

        }
        #endregion

        #region Override ToString & Equals
        public override bool Equals(object? obj)
        {
            Fraction f = obj as Fraction;
            if (f == null || this.GetType() != f.GetType())
                return false;
            return Numerator == f.Numerator && Denominator == f.Denominator;
        }
        public override string ToString() => $"{Numerator}/{Denominator}"; 
        #endregion


    }
}
