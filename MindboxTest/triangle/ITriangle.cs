using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindboxTest.triangle
{
    public interface ITriangle
    {
        int sideA {  get; }
        int sideB { get; }
        int sideC { get; }
        bool isTriangleRight();
        double getArea();
       
    }
}
