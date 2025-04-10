using Lab09;

public interface IGraphic2DFactory
{
    public string Name {get;}
    
    public IGraphic2D Create();

}