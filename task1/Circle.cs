public class Circle
{
    public int Radius;
    public string Colour;
    public float pi;

    public void GetArea()
    {
        System.Console.WriteLine($"Area of circle = {pi*Radius*Radius}");
    }
    public void GetCircumference()
    {
        System.Console.WriteLine($"Circumference of circle = {2*pi*Radius}");
    }
}