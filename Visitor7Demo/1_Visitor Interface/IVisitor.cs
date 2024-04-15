using Visitor7Demo._4__Implement_Concrete_Elements;

namespace Visitor7Demo._1_Visitor_Interface;

internal interface IVisitor
{
    string VisitTextToHtmlConverter(TextToHtmlConverter component, string text);
    string VisitHtmlToTextConverter(HtmlToTextConverter component, string text);
}