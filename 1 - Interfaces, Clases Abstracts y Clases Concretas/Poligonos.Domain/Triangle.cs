using System;

namespace Poligonos.Domain
{
    //TODO: 08 - Impelmento la clase Triangle y heredo de la clase Abstracta  AbstractRegularPolygon
    public class Triangle : AbstractRegularPolygon
    {
        public Triangle(int length) :
            base(3, length)
        { }
        //TODO: 09 - Implemento el metodo GetArea
        public override double GetArea()
        {
            return SideLength * SideLength * Math.Sqrt(3) / 4;
        }
    }
}