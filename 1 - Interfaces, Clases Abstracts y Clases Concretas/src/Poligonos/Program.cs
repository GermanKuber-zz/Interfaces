using System;
using Poligonos.Domain;

namespace Poligonos
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO : 05 - Llamo a la clase concreta Square
            //var square = new Square(5);
            //DisplayPolygon("Square", square);

            //TODO : 10 - Llame a Triangle clase que hereda de la clase abstracta AbstractRegularPolygon
            //var triangle = new Triangle(5);
            //DisplayPolygon("Triangle", triangle);

            //TODO : 13 - Llamo al Octagono que implementa la interface
            IRegularPolygon octagon = new Octagon(5);
            DisplayPolygon("Octagon", octagon);

            Console.Read();
        }

        public static void DisplayPolygon(string polygonType, dynamic polygon)
        {
            try
            {
                Console.WriteLine("{0} Cantidad de lados: {1}", polygonType, polygon.Sides);
                Console.WriteLine("{0} Largo de lados: {1}", polygonType, polygon.SideLength);
                Console.WriteLine("{0} Perimetro: {1}", polygonType, polygon.GetPerimeter());
                Console.WriteLine("{0} Area: {1}", polygonType, Math.Round(polygon.GetArea(), 2));
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
