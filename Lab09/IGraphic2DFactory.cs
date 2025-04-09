using Lab09;

public interface IGraphic2DFactory
{
    //readonly string Name {get; set;}
    
    public IGraphic2D Create()
    {
        //dummy return value to prevent compiler from getting upset
        return new Circle(1,1,4);
    }
}