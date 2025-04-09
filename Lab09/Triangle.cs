using Lab09;

public class Triangle : AbstractGraphic2D
{
    public int CenterX;
    public int CenterY;
    public decimal Height;
    public Triangle(int centerX, int centerY, decimal height)
    {
        CenterX = centerX;
        CenterY = centerY;
        Height = height;
    }
    public override decimal LowerBoundX => CenterX - (Height/2);
    public override decimal UpperBoundX => CenterX + (Height/2);

    public override decimal LowerBoundY => CenterY - (Height/2);

    public override decimal UpperBoundY => CenterY + (Height/2);

    public override bool ContainsPoint(decimal x, decimal y)
    {
        decimal x1 = CenterX, y1 = CenterY + Height / 2;
        decimal x2 = CenterX - Height / 2, y2 = CenterY - Height / 2;
        decimal x3 = CenterX + Height / 2, y3 = CenterY - Height / 2;

        // Bounding box check
        if (x < x2 || x > x3 || y < y2 || y > y1) return false;

        // Line equations
        decimal leftEdge = (y2 - y1) / (x2 - x1) * (x - x1) + y1;
        decimal rightEdge = (y3 - y1) / (x3 - x1) * (x - x1) + y1;

        return y <= leftEdge && y <= rightEdge;
    }

}