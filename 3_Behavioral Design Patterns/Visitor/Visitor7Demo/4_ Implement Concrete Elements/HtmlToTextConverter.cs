using Visitor7Demo._1_Visitor_Interface;
using Visitor7Demo._3_Define_the_Element_Interface;

namespace Visitor7Demo._4__Implement_Concrete_Elements;

internal class HtmlToTextConverter : IComponent
{
    public string Accept(IVisitor visitor, string text)
    {
        return visitor.VisitHtmlToTextConverter(this, text);
    }

    public string ProcessParagraphs(string text)
    {
        return text
            .Replace("<p>", "")
            .Replace("</p>", "\n")
            .Replace("<br/>", "");
    }
}