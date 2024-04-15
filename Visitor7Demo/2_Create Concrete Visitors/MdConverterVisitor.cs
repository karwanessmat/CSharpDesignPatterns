using Visitor7Demo._1_Visitor_Interface;
using Visitor7Demo._4__Implement_Concrete_Elements;

namespace Visitor7Demo._2_Create_Concrete_Visitors;

internal class MdConverterVisitor : IVisitor
{
    public string VisitTextToHtmlConverter(TextToHtmlConverter component, string text)
    {
        text = component.ProcessParagraphs(text);

        var tagsToReplace = new Dictionary<string, (string, string)>
        {
            { "**", ("<strong>", "</strong>") },
            { "*", ("<em>", "</em>") },
            { "~~", ("<del>", "</del>") }
        };

        foreach (var key in tagsToReplace.Keys)
        {
            var replacementTags = tagsToReplace[key];

            if (CountStringOccurrences(text, key) % 2 == 0)
                text = ApplyTagReplacement(text, key, replacementTags.Item1, replacementTags.Item2);
        }

        return text;
    }

    public string VisitHtmlToTextConverter(HtmlToTextConverter component, string text)
    {
        return component.ProcessParagraphs(text)
            .Replace("<strong>", "**")
            .Replace("</strong>", "**")
            .Replace("<em>", "*")
            .Replace("</em>", "*")
            .Replace("<del>", "~~")
            .Replace("</del>", "~~");
    }

    private int CountStringOccurrences(string text, string pattern)
    {
        int count = 0;
        int currentIndex = 0;
        while ((currentIndex = text.IndexOf(pattern, currentIndex)) != -1)
        {
            currentIndex += pattern.Length;
            count++;
        }
        return count;
    }

    private string ApplyTagReplacement(string text, string inputTag, string outputOpeningTag, string outputClosingTag)
    {
        int count = 0;
        int currentIndex = 0;

        while ((currentIndex = text.IndexOf(inputTag, currentIndex)) != -1)
        {
            count++;

            if (count % 2 != 0)
            {
                var prepend = outputOpeningTag;
                text = text.Insert(currentIndex, prepend);
                currentIndex += prepend.Length + inputTag.Length;
            }
            else
            {
                var append = outputClosingTag;
                text = text.Insert(currentIndex, append);
                currentIndex += append.Length + inputTag.Length;
            }
        }

        return text.Replace(inputTag, string.Empty);
    }
}