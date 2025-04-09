using System.Reflection.Metadata.Ecma335;
using Lab09;

public class CircleFactory : IGraphic2DFactory
{
    public IGraphic2D Create()
    {
        int xCoordinate;
        int yCoodinate;
        int radius;
        Console.WriteLine("Please provide an x coordinate");
        xCoordinate = ValidateAnswer();
        Console.WriteLine("Please provide a y coordinate");
        yCoodinate = ValidateAnswer();
        Console.WriteLine("Please provide a radius");
        radius = ValidateAnswer();
        return new Circle(xCoordinate, yCoodinate, radius);
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