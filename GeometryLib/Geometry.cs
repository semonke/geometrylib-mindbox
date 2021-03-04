/*============================================================
**
** Class:  Geometry
**
**
** Purpose: Some geometric operations
**
** 
===========================================================*/
namespace GeometryLib
{
    using System;
    public static class Geometry
    {
        private static bool Exists(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
                return false;
            return true;
        }
        
        public static double AreaOf(double radius)
        {
            if (radius <= 0)
                throw new GeometricException("Incorrect radius value");
            return Math.PI * radius * radius;
        }

        public static double AreaOf(double a, double b, double c)
        {
            if (!Exists(a, b, c))
                throw new GeometricException("Incorrect sides value");
            double semiPer = (a + b + c) / 2;
            return Math.Sqrt(semiPer * (semiPer - a) * (semiPer - b) * (semiPer - c));
        }

        public static bool IsRightTriangle(double a, double b, double c)
        {
            if (!Exists(a, b, c))
                throw new GeometricException("Incorrect sides value");
            if (a * a + b * b == c * c || a * a + c * c == b * b || c * c + b * b == a * a)
                return true;
            return false;
        }
        
        //TODO: Implement more figures
        
    }
}