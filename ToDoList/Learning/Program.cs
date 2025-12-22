Rectangle rectangle1 = new Rectangle(5, 10);
Console.WriteLine($"Rectangle infos : width {rectangle1.width}, height {rectangle1.height}");


Console.ReadKey();

class Rectangle
{
    public int width;
    public int height;

    public Rectangle(int _width, int _height)
    {
        width = _width;
        height = _height;
    }
}