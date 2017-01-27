using System;

namespace Poligonos.Domain
{
    //TODO : 12 - Implemento la Interface IRegularPolygon - Multiple Herencia
    public class Octagon : Object, IRegularPolygon
    {
        public int Sides { get; set; }
        public int SideLength { get; set; }

        public Octagon(int length)
        {
            Sides = 8;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return Sides * SideLength;
        }

        public double GetArea()
        {
            return SideLength * SideLength * (2 + 2 * Math.Sqrt(2));
        }
    }
}