using Lab09;

public interface IGraphic2DFactory
{
    public string Name {get; set;}
    
    public IGraphic2D Create();

}