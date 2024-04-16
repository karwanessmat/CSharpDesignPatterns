namespace Proxy7Demo;

public class CoolImageControl
{
    private readonly Dictionary<string, IImage> _images = new();

    public void Add(IImage image)
    {
        _images.Add(image.FileName, image);
    }

    public void OpenImage(string fileName)
    {
        _images[fileName].ShowImage();
    }
}