using Strategy4Demo._1_Define_Strategy_Interface;

namespace Strategy4Demo._2_Concrete_Strategies;

public class SevenZipCompressionStrategy : ICompressionStrategy
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine($"Compressing folder into a 7z file: {compressedArchiveFileName}.7z");
        // Implement 7z compression logic here
    }
}