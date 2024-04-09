using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy7Demo;

public interface IImage
{
    string FileName { get; }

    void ShowImage();
}