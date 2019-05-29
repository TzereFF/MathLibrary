using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMathLibrary
{
    public class Geometry
    {
        public enum TriangleType { NotTriangle, Obtuse, Acute, Right }
        public static TriangleType GetTriangleType(float sideA, float sideB, float sideC)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA)
            {
                float h, k, l;
                if (sideA >= sideB && sideA >= sideC)
                {
                    h = sideA;
                    k = sideB;
                    l = sideC;
                }
                else if (sideB > sideC)
                {
                    h = sideB;
                    k = sideA;
                    l = sideC;
                }
                else
                {
                    h = sideC;
                    k = sideA;
                    l = sideB;
                }
                h *= h;
                k *= k;
                l *= l;
                if (h == k + l)
                    return TriangleType.Right;
                if (h > k + l)
                    return TriangleType.Obtuse;
                if (h < k + l)
                    return TriangleType.Acute;
                
            }
            return TriangleType.NotTriangle;
        }
    }
}
