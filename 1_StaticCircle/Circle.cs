using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_StaticCircle
{
    public static class Circle
    {

        public static double Circumference(double Radius)
        {
            return 2 * Math.PI * Radius;
        }

        public static double Sqr(double Radius)
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public static string PointInCircle(double centerX0, double centerY0, double pointX, double pointY, double Radius)
        {
            string resultPointInCircle;
            resultPointInCircle = (Math.Sqrt(Math.Pow(pointX - centerX0, 2) + Math.Pow(pointY - centerY0, 2)) <= Radius) ? "входит" : "не входит";
            return resultPointInCircle;
        }
    }
}
