using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy4Demo._1_Define_Strategy_Interface
{
    public interface ICompressionStrategy
    {
        void CompressFolder(string compressedArchiveFileName);
    }
}
