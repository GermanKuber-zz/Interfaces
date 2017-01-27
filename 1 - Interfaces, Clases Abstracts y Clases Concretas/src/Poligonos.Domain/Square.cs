namespace Poligonos.Domain
{
    //TODO : 02 - Creo la clase concreta Square que hereda de RegularPolygon
    public class Square : RegularPolygon
    {

        public Square(int length) :
            base(4, length)
        {
            //TODO : 03 - Envio como parametro a mi clase base que tiene 4 lados

        }
        //TODO : 04 - Sobreescribo el metodo GetArea
        public override double GetArea()
        {
            return SideLength * SideLength;
        }
    }
}