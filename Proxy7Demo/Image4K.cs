using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy7Demo;

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
