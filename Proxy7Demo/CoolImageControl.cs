using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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