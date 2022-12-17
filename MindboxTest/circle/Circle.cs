
using System;


namespace MindboxTest
{
    public class Circle:ICircle
    {
        public Circle(double radius) {
            if (radius < 0) { throw new ArgumentException("Wrong radius of circle", nameof(radius)); }
            else { Radius = radius;}
        }
        public double Radius { get; }
       public double getArea()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        } 
    }
}