using Proxy7Demo;

var control = new CoolImageControl();
List<string> fileNames = new List<string>();

for (int i = 0; i < 10; i++)
{
    fileNames.Add($@"C:\file{i}.jpg");
}

foreach (var file in fileNames)
{
    control.Add(new Image4KProxy(file));
}

control.OpenImage("file1.jpg");