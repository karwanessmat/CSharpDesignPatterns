using System.Text;
using System.Text.RegularExpressions;
using Visitor7Demo._1_Visitor_Interface;
using Visitor7Demo._3_Define_the_Element_Interface;

namespace Visitor7Demo._4__Implement_Concrete_Elements;

internal class TextToHtmlConverter : IComponent
{
    public string Accept(IVisitor visitor, string text)
    {
        return visitor.VisitTextToHtmlConverter(this, text);
    }

    public string ProcessParagraphs(string text)
    {
        var paragraphs = Regex.Split(text, @"(\r\n?|\n)")
            .Where(p => p.Any(char.IsLetterOrDigit));

        var sb = new StringBuilder();

        foreach (var paragraph in paragraphs)
        {
            if (paragraph.Length == 0)
                continue;

            sb.AppendLine($"<p>{paragraph}</p>");
        }

        sb.AppendLine("<br/>");
        return sb.ToString();
    }
}