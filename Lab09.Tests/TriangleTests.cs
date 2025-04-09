namespace Lab09.Tests;
public class TriangleTests
{
    Triangle triangle;
    AbstractGraphic2D shape;

    [SetUp]
    public void Setup()
    {
        triangle = new Triangle(3, 4, 5);
        shape = triangle;
    }

    [Test]
    public void EnsurePropertiesAreCorrect()
    {
        Assert.AreEqual(3, triangle.CenterX);
        Assert.AreEqual(4, triangle.CenterY);
        Assert.AreEqual(5, triangle.Height);
    }

    [Test]
    public void CheckLowerBounds()
    {
        // lower bound is the smallest x that needs to be checked when drawing the shape
        Assert.AreEqual(3 - (decimal) 5/2, shape.LowerBoundX);
        Assert.AreEqual(4 + (decimal) 5/2, shape.LowerBoundY);
    }

    [Test]
    public void CheckUpperBounds()
    {
        // upper bound is the largest x that needs to be checked when drawing the shape
        Assert.AreEqual(3 + (decimal) 5/2, shape.UpperBoundX);
        Assert.AreEqual(4 - (decimal) 5/2, shape.UpperBoundY);
    }

    [Test]
    public void MiddleOfShapeIsIncluded()
    {
        Assert.IsTrue(shape.ContainsPoint(3, 4));
    }

    [Test]
    public void CornersNotIncluded()
    {
        Assert.IsFalse(shape.ContainsPoint(3 + (decimal) 5/2, 4 - (decimal) 5/2));
        Assert.IsFalse(shape.ContainsPoint(3 - (decimal) 5/2, 4 - (decimal) 5/2));
    }

    [Test]
    public void VerticesIncluded()
    {
        Assert.IsTrue(shape.ContainsPoint(3, 4 - (decimal) 5/2));
        Assert.IsTrue(shape.ContainsPoint(3 + (decimal) 5/2, 4 - (decimal) 5/2));
        Assert.IsTrue(shape.ContainsPoint(3 - (decimal) 5/2, 4 - (decimal) 5/2));
    }

    [Test]

    public void OutsideTriangleNotIncluded()
    {
        Assert.IsFalse(shape.ContainsPoint(3 + (decimal) 5/2, 4));
        Assert.IsFalse(shape.ContainsPoint(3 - (decimal) 5/2, 4));
    }
}