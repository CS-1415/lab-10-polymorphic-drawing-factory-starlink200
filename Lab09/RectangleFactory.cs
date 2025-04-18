using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using Lab09;

public class RectangleFactory : IGraphic2DFactory
{

    public string Name
    {
        get{return "Rectangle";}
    }

    public IGraphic2D Create()
    {
        int xCoordinate;
        int yCoordinate;
        int height;
        int width;
        Console.WriteLine("Please provide the X coordinate for the top left corner of this rectangle");
        xCoordinate = ValidateAnswer();
        Console.WriteLine("Please provide the Y coordinate for the top left corner of this rectangle");
        yCoordinate = ValidateAnswer();
        Console.WriteLine("Please provide the height of this rectangle");
        height = (int)(decimal) ValidateAnswer();
        Console.WriteLine("Please provide the width of this rectangle");
        width = ValidateAnswer();
        return new Rectangle(xCoordinate, yCoordinate, width, height);//{ ForegroundColor = ConsoleColor.DarkGreen, DisplayChar = '#' };
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