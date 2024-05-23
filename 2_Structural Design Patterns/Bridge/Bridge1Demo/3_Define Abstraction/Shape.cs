using Bridge1Demo._1_Define_Implementor_Interface;

namespace Bridge1Demo._3_Define_Abstraction;

public abstract class Shape(IDraw draw)
{

    /// <summary>
    /// this is a bridge
    /// </summary>
    protected IDraw DrawApi = draw;

    public abstract void Draw();
}