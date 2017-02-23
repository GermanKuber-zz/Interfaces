namespace Poligonos.Domain
{
    //TODO: 06 - Implemento una clase Abstracta
    public abstract class AbstractRegularPolygon
    {
        public int Sides { get; set; }
        public int SideLength { get; set; }

        protected AbstractRegularPolygon(int sides, int length)
        {
            Sides = sides;
            SideLength = length;
        }

        public double GetPerimeter()
        {
            return Sides * SideLength;
        }
        //TODO: 07 - Marco el metodo que quiero obligar a implementar como Abstracto
        public abstract double GetArea();
    }
}