namespace Poligonos.Domain
{
    //TODO: 11 - Implemento la interface IRegularPolygon
    public interface IRegularPolygon
    {
        int Sides { get; set; }
        int SideLength { get; set; }

        double GetPerimeter();
        double GetArea();
    }
}