Rectangle rectangle1 = new Rectangle(5, 10);
Console.WriteLine(rectangle1.ShowRectangleInfos());
Console.WriteLine($"Perimeter is : {rectangle1.CalculatePerimeter()}");
Console.WriteLine($"Area is : {rectangle1.CalculateArea()}");


Console.ReadKey();

class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public string ShowRectangleInfos() => $"Rectangle infos : width {Width}, height {Height}";

    public int CalculateArea() => Width * Height;

    public int CalculatePerimeter() => 2 * Width + 2 * Height;
}