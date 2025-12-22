Rectangle rectangle1 = new Rectangle(5, 10);
Console.WriteLine(rectangle1.ShowRectangleInfos());
Console.WriteLine($"Perimeter is : {rectangle1.CalculatePerimeter()}");
Console.WriteLine($"Area is : {rectangle1.CalculateArea()}");


Console.ReadKey();

class Rectangle
{
    readonly int Width;
    readonly int Height;

    public Rectangle(int _width, int _height)
    {
        Width = _width;
        Height = _height;
    }

    public string ShowRectangleInfos()
    {
        return $"Rectangle infos : width {Width}, height {Height}";
    }

    public int CalculateArea()
    {
        return Width * Height;
    }

    public int CalculatePerimeter()
    {
        return 2 * Width + 2 * Height;
    }
}