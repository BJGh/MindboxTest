

using MindboxTest.triangle;
using System;

namespace MindboxTest
{
    public class Triangle:ITriangle
    {
        public int sideA { get; set; }
        public int sideB { get; set; } 
        public int sideC { get; set; }
        public bool isTriangleRight()
        {
            if (sideA * sideA == sideB * sideB + sideC * sideC)
                return true;
            else { return false; }
               
        }
        public double getArea()
        {
            double semiperimeter = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(semiperimeter*(semiperimeter-sideA)*(semiperimeter-sideB)*(semiperimeter-sideB));
        }
    
    }
}