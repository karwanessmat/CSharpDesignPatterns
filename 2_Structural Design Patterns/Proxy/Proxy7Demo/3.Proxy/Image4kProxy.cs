using Proxy7Demo._1.Subject_Interface;
using Proxy7Demo._2.RealSubject;

namespace Proxy7Demo._3.Proxy;

public class Image4KProxy : IImage
{
    private  Image4k Image;
    public Image4KProxy(string filePath)
    {
        FileName = Path.GetFileName(filePath);
    }
    public string FileName { get; }
    public void ShowImage()
    {
        if (Image is null)
        {
            Image = new Image4k(FileName);
        }
        Image.ShowImage();
    }
}