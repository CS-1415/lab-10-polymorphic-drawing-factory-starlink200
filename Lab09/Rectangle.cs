using Lab09;

public class Rectangle : AbstractGraphic2D
{

    public int Top;
    public int Left;
    public int Width;
    public decimal Height;

    public Rectangle(int left, int top, int width, decimal height)
    {
        Left = left;
        Top = top;
        Width = width;
        Height = height;
    }
    public override decimal LowerBoundX => Left;

    public override decimal UpperBoundX => Left + Width;

    public override decimal LowerBoundY => Top;

    public override decimal UpperBoundY => Top + Height;

    public override bool ContainsPoint(decimal x, decimal y)
    {
        if(x >= LowerBoundX && x <= UpperBoundX && y >= LowerBoundY && y <= UpperBoundY)
        {
            return true;
        }
        return false;
    }
}