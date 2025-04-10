using System.Reflection.Metadata.Ecma335;
using Lab09;

public class CircleFactory : IGraphic2DFactory
{
    public string Name
    {
        get{return "Circle";}
    }
    public IGraphic2D Create()
    {
        int xCoordinate;
        int yCoodinate;
        int radius;
        Console.WriteLine("Please provide an x coordinate for the center of your circle");
        xCoordinate = ValidateAnswer();
        Console.WriteLine("Please provide a y coordinate for the center of your circle");
        yCoodinate = ValidateAnswer();
        Console.WriteLine("Please provide a radius for your circle");
        radius = ValidateAnswer();
        return new Circle(xCoordinate, yCoodinate, radius);//{ BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' };
    }

    public int ValidateAnswer()
    {
        int num;
        bool isValid;
        do
        {
            isValid = int.TryParse(Console.ReadLine(), out num);

        }
        while(!isValid);
        return num;
    }
}