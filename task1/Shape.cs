public class Shape
{
    public string Colour;
    public string Name;
    public int PositionX;
    public int PositionY;

    public void GetPosition()
    {
        System.Console.WriteLine($"PositionX = {PositionX} PositionY = {PositionY}");
    }
    public void GetFullinfo()
    {
        System.Console.WriteLine($"Colour: {Colour} Name: {Name} PositionX = {PositionX} PositionY = {PositionY}");
    }
}