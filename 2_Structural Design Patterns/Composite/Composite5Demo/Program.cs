using Composite5Demo._2._Leaf;
using Composite5Demo._3.Composite;

var rootFolder = new Folder("Root");
rootFolder.Add(new Folder("Folder1"));
rootFolder.Add(new Folder("Folder2"));

var complexFolder = new Folder("Folder3");
complexFolder.Add(new Folder("Folder4"));
complexFolder.Add(new FileItem("NewFile.xml"));
complexFolder.Add(new FileItem("NewFile2.xml"));

rootFolder.Add(complexFolder);

rootFolder.DisplayChildren(string.Empty);

Console.ReadKey();