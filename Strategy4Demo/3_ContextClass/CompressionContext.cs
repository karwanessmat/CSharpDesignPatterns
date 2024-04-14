using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy4Demo._1_Define_Strategy_Interface;

namespace Strategy4Demo._3_ContextClass
{
    public class CompressionContext(ICompressionStrategy compressionStrategy)
    {
        private readonly ICompressionStrategy _compressionStrategy = compressionStrategy;


        public void CreateArchive(string compressedArchiveFileName)
        {
            _compressionStrategy.CompressFolder(compressedArchiveFileName);
        }
    }
}
