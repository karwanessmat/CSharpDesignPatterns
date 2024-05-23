using Proxy7Demo;
using Proxy7Demo._3.Proxy;

var control = new CoolImageControl();
List<string> fileNames = new List<string>();

for (int i = 0; i < 10; i++)
{
    fileNames.Add($@"C:\file{i}.jpg");
}

foreach (string? file in fileNames)
{
    control.Add(new Image4KProxy(file));
}

control.OpenImage("file1.jpg");