
using Composite4Demo._1._Component;
using Composite4Demo._3.Composite;
using Composite4Demo._2._Leaf;

var myDocuments = new DirectorySys("MyDocuments");
var resumeDoc = new FileSystem("resume.docx");

var music = new DirectorySys("Music");
var song1 = new FileSystem("song1.mp3");
var song2 = new FileSystem("song2.mp3");

music.Add(song1);
music.Add(song2);

myDocuments.Add(resumeDoc);
myDocuments.Add(music);

myDocuments.Display(1);