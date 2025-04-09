using Lab09;
internal class Program
{
    private static void Main(string[] args)
    {
        List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>();
        List<IGraphic2D> builtShapes = new List<IGraphic2D>();
        Introduction();
        bool quit = false;
        while(!quit)
        {
            UserOptions(builtShapes);
        }

    }

    public static void Introduction()
    {
        Console.WriteLine("Hello! This program will allow you to draw a number of shapes according to how you desire!");
    }

    public static bool UserOptions(List<IGraphic2D> shapes)
    {
        int num;
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1: Display your drawing");
        Console.WriteLine("2: Add to my drawing");
        Console.WriteLine("3: Remove from my drawing");
        Console.WriteLine("4: Exit program");
        num = ValidateAnswer(4, 1);
        switch (num)
        {
            case 1:
                DisplayDrawing(shapes);
                break;
            case 2:
                AddGraphic();
                break;
            case 3:
                RemoveGraphic();
                break;
            case 4:
                return ExitProgram();
        }
        return false;
    }

    public static void DisplayDrawing(List<IGraphic2D> shapes)
    {
        Console.Clear();
        AbstractGraphic2D.Display(shapes);
    }

    public static void AddGraphic()
    {
        
    }

    public static void RemoveGraphic()
    {

    }

    public static bool ExitProgram()
    {
        return false;
    }
    
    public static int ValidateAnswer(int max = 100000000, int min = 0)
    {
        int num;
        bool isValid;
        do
        {
            isValid = int.TryParse(Console.ReadLine(), out num);
            if(num > max || num < min)
            {
                isValid = false;
            }
            if(isValid = false)
            {
                Console.WriteLine($"Please give an acceptable value between {min} and {max}");
            }
        }
        while(!isValid);
        return num;
    }
}