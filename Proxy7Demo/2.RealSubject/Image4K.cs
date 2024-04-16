using Proxy7Demo._1.Subject_Interface;

namespace Proxy7Demo._2.RealSubject;

public class Image4k : IImage
{
    public string FileName { get; }
    public Image4k(string imagePath)
    {
        FileName = Path.GetFileName(imagePath);
        LoadImage(imagePath);
    }

    private void LoadImage(string imagePath)
    {
        Console.WriteLine(@$"Loading {FileName} from disk");
    }

    public void ShowImage()
    {
        Console.WriteLine($"Showing {FileName} image");
    }
}
