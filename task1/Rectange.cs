public class Rectange
{
    public int Width;
    public int Height;
    public string Colour;

public void GetArea()
{
    System.Console.WriteLine($"Area of rectange: {Width*Height}");
}
public void GetPerimeter()
{
    System.Console.WriteLine($"Perimeter of rectange: {2*(Width+Height)}");
}
}