using Strategy4Demo._1_Define_Strategy_Interface;

namespace Strategy4Demo._2_Concrete_Strategies;

public class ZipCompressionStrategy : ICompressionStrategy
{
    public void CompressFolder(string compressedArchiveFileName)
    {
        Console.WriteLine($"Compressing folder into a ZIP file: {compressedArchiveFileName}.zip");
        // Implement ZIP compression logic here
    }
}