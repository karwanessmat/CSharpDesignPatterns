using Strategy4Demo._1_Define_Strategy_Interface;

namespace Strategy4Demo._2_Concrete_Strategies;

public class RarCompressionStrategy : ICompressionStrategy
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine($"Compressing folder into a RAR file: {compressedArchiveFileName}.rar");
        // Implement RAR compression logic here    
    }
}