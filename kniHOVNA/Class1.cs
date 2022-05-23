using System;

namespace matematika
{
    public class Class1
    {
        static public double Obsah(double a, out double u)
        {

            u = a * Math.Sqrt(2);
            double obsah = a * a;
            return obsah;
        }
        static public double Obsah(double a, double b, out double u)
        {

            u = Math.Sqrt(a * a + b * b);
            double obsah = a * b;
            return obsah;
        }
        static public double Objem(double a, out double u)
        {
            double objem;
            u = a * Math.Sqrt(3);
            objem = a * a * a;
            return objem;
        }
        static public double Objem(double a, double b, double c, out double u)
        {
            double objem;
            u = Math.Sqrt(a * a + b * b + c * c);
            objem = a * b * c;
            return objem;
        }
    }
}
