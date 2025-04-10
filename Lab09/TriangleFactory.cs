using Lab09;

public class TriangleFactory : IGraphic2DFactory
{
    public string Name
    {
        get{return "Triangle";}
    }

    public IGraphic2D Create()
    {
        int xCoordinate;
        int yCoordinate;
        int height;
        Console.WriteLine("What is the x coordinate for the center of your triangle?");
        xCoordinate = ValidateAnswer();
        Console.WriteLine("What is the y coordinate for the center of your triangle?");
        yCoordinate = ValidateAnswer();
        Console.WriteLine("What is the height of your triangle?");
        height = ValidateAnswer();
        return new Triangle(xCoordinate, yCoordinate, height);
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