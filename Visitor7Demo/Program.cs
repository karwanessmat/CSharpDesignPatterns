using Visitor7Demo._2_Create_Concrete_Visitors;
using Visitor7Demo._4__Implement_Concrete_Elements;

var mdText = @"This is **first** paragraph.
This is *second* paragraph.
This is ~~third~~ paragraph.";

var htmlText = @"<p>This is <strong>first</strong> paragraph.</p>
<p>This is <em>second</em> paragraph.</p>
<p>This is <del>third</del> paragraph.</p>
<br/>";

var visitor = new MdConverterVisitor();
var textToHtmlConverter = new TextToHtmlConverter();
var htmlToTextConverter = new HtmlToTextConverter();

Console.WriteLine("MD text converted to HTML:");
Console.WriteLine(textToHtmlConverter.Accept(visitor, mdText));
Console.WriteLine("");
Console.WriteLine("HTML text converted to MD:");
Console.WriteLine(htmlToTextConverter.Accept(visitor, htmlText));

Console.ReadKey();