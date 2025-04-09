using Lab09;
internal class Program
{
    private static void Main(string[] args)
    {
        List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>();
        List<IGraphic2D> builtShapes = new List<IGraphic2D>();
        List<IGraphic2D> shapes = new List<IGraphic2D>
        {
            new Circle(10, 10, 5) { BackgroundColor = ConsoleColor.DarkYellow, DisplayChar = ' ' },
            new Circle(8, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
            new Circle(12, 10, 1m) { BackgroundColor = ConsoleColor.White, ForegroundColor = ConsoleColor.Gray, DisplayChar = '.' },
            new Circle(8, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
            new Circle(12, 10, 0.5m) { BackgroundColor = ConsoleColor.Blue, ForegroundColor = ConsoleColor.DarkBlue, DisplayChar = '.' },
            new Rectangle(8, 13, 4, 0.5m) { ForegroundColor = ConsoleColor.DarkGray, DisplayChar = 'v' },
            new Rectangle(8, 16, 4, 10) { ForegroundColor = ConsoleColor.DarkGreen, DisplayChar = '#' }
            //new Triangle(10, 10, 5m) {ForegroundColor = ConsoleColor.DarkCyan, DisplayChar = '*'}
        };
        Introduction();
        bool quit = false;
        while(!quit)
        {
            quit = UserOptions(shapes);
        }

    }

    public static void Introduction()
    {
        Console.WriteLine("Hello! This program will allow you to draw a number of shapes according to how you desire!");
        Console.WriteLine("Press any button to continue");
        Console.ReadKey();
    }

    public static bool UserOptions(List<IGraphic2D> shapes)
    {
        Console.Clear();
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
        Console.WriteLine("Press any button to continue");
        Console.ReadKey();
    }

    public static void AddGraphic()
    {

    }

    public static void RemoveGraphic()
    {

    }

    public static bool ExitProgram()
    {
        Console.WriteLine("Would you like to quit? 1: Yes 2: No");
        int num = ValidateAnswer(2, 1);
        switch (num)
        {
            case 1:
                return true;
            default:
                return false;
        }
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
            if(isValid == false)
            {
                Console.WriteLine($"Please give an acceptable value between {min} and {max}");
            }
        }
        while(!isValid);
        return num;
    }

    // public static IGraphic2D PickShape()
    // {
    //     Console.WriteLine("What kind of shape would you like to draw");
    //     //for(int i = 0; i < )
    // }
}