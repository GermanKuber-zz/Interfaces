using System;

namespace Poligonos.Domain
{
    //TODO: 01 - Creo la clase Concreta RegularPolygon
    public class RegularPolygon
    {
        public int Sides { get; set; }
        public int SideLength { get; set; }

        public RegularPolygon(int sides, int length)
        {
            Sides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return Sides * SideLength;
        }

        public virtual double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
