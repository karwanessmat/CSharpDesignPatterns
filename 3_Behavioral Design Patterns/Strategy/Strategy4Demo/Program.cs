using Strategy4Demo._2_Concrete_Strategies;
using Strategy4Demo._3_ContextClass;

var cc = new CompressionContext(new ZipCompressionStrategy());
cc.CreateArchive("example");


cc = new CompressionContext(new RarCompressionStrategy());
cc.CreateArchive("example");


cc = new CompressionContext(new SevenZipCompressionStrategy());
cc.CreateArchive("example");
