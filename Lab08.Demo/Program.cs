using Lab08.Utility;

namespace Lab08.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Complex numbers
            //Complex c1 = new Complex(3,2);
            //Complex c2 = new Complex(3,2);
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c1 + c2);
            //Console.WriteLine(c1 == c2);
            //Console.WriteLine(c1 != c2);
            //c1--;
            //c2++;
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine(c1 == c2);
            //Console.WriteLine(c1 != c2); 
            #endregion

            #region Maths static Class
            //Console.WriteLine(Maths.Divide(5, 2));
            //Console.WriteLine(Maths.Add(5, 2));
            //Console.WriteLine(Maths.Subtract(5, 2));
            //Console.WriteLine(Maths.Mul(5, 2)); 
            #endregion

            #region Fractions
            //Fraction f1 = new Fraction(20,60);
            //Console.WriteLine(f1);
            //Fraction f2 = new Fraction(10,30);
            //Console.WriteLine(f2);
            //Console.WriteLine(f1++);
            //Console.WriteLine(f2++);
            //Console.WriteLine(f1 == f2);
            //Console.WriteLine(f1 + f2);
            //Fraction f3 = new Fraction(3,4);
            //Console.WriteLine(f3 + 2);

            //Console.WriteLine(Fraction.Simplify(10,-20)); 
            #endregion

            #region Duration
            Duration d1 = new Duration(1, 0, 0);
            Console.WriteLine(d1);
            Duration d2 = new Duration(3600);
            Console.WriteLine(d1 == d2);
            Console.WriteLine(d2);
            Console.WriteLine(d1 >= d2);
            Console.WriteLine(d1 + 119);
            Console.WriteLine(--d2);
            Console.WriteLine(d1 != d2);
            Duration d3 = d1 + d2;
            Console.WriteLine(d3); 
            #endregion

        }
    }
}
