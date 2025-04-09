using Lab09;
internal class Program
{
    private static void Main(string[] args)
    {
        Introduction();
        bool quit = false;
        List<IGraphic2DFactory> availableShapeTypes = new List<IGraphic2DFactory>();
        List<IGraphic2D> builtShapes = new List<IGraphic2D>();
        availableShapeTypes.Add(new RectangleFactory());
        availableShapeTypes.Add(new CircleFactory());
        while(!quit)
        {
            int num;
            Console.Clear();
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1: Display your drawing");
            Console.WriteLine("2: Add to my drawing");
            Console.WriteLine("3: Remove from my drawing");
            Console.WriteLine("4: Exit program");
            num = ValidateAnswer(4, 1);
            switch (num)
            {
                case 1:
                    DisplayDrawing(builtShapes);
                    break;
                case 2:
                    IGraphic2D graphic2D = AddGraphic(availableShapeTypes);
                    builtShapes.Add(graphic2D);
                    foreach(var shape in builtShapes)
                    {
                        Console.WriteLine(shape);
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    int index = RemoveGraphic(builtShapes);
                    builtShapes.Remove(builtShapes[index]);
                    break;
                case 4:
                    quit = ExitProgram();
                    break;
            }
        }
    }

    public static void Introduction()
    {
        Console.WriteLine("Hello! This program will allow you to draw a number of shapes according to how you desire!");
        Console.WriteLine("Press any button to continue");
        Console.ReadKey();
    }


    public static void DisplayDrawing(List<IGraphic2D> shapes)
    {
        Console.Clear();
        AbstractGraphic2D.Display(shapes);
        Console.WriteLine("Press any button to continue");
        Console.ReadKey();
    }

    public static IGraphic2D AddGraphic(List<IGraphic2DFactory> options)
    {
        int num;
        Console.WriteLine("What kind of shape would you like to add?");
        for(int i = 0; i < options.Count ; i++)
        {
            Console.WriteLine($"{i+1}: {options[i]}");
        }
        num = ValidateAnswer(options.Count, 1);
        return options[num - 1].Create();
    }

    public static int RemoveGraphic(List<IGraphic2D> shapes)
    {
        Console.WriteLine("Which shape would you like to remove from your drawing?");
        int i = 1;
        foreach(var shape in shapes)
        {
            Console.WriteLine($"{i}: {shape}");
            i++;
        }
        int num = ValidateAnswer(shapes.Count, 1);
        return num - 1;
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
}