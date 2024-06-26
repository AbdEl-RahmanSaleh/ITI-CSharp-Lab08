using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08.Utility
{
    public class Complex
    {
        public int Real { get; set; }
        public int Img { get; set; }

        public Complex(int real = 0, int img = 0)
        {
            Real = real;
            Img = img;
        }

        #region Operators Overloading
        public static Complex operator +(Complex l, Complex r) => new Complex(l.Real + r.Real, l.Img + r.Img);
        public static Complex operator +(Complex l, int r) => new Complex(l.Real + r, l.Img);
        public static Complex operator +(int l, Complex r) => r + l;
        public static Complex operator ++(Complex c) => new Complex(c.Real + 1, c.Img);
        public static Complex operator --(Complex c) => new Complex(c.Real - 1, c.Img);
        public static bool operator ==(Complex l, Complex r) => l.Real == r.Real && l.Img == r.Img;
        public static bool operator !=(Complex l, Complex r) => !(l == r);
        #endregion

        #region Override ToString & Equals
        public override bool Equals(object? obj)
        {
            Complex c = obj as Complex;
            if (c == null || this.GetType() != c.GetType())
                return false;
            return Real == c.Real && Img == c.Img;
        }
        public override string ToString()
        {
            if (Img == 0)
                return $"{Real}";
            else if (Img >= 0)
            {
                return $"{Real} + {Img}i";
            }
            else
            {
                return $"{Real} - {-Img}i";
            }
        } 
        #endregion

    }
}
