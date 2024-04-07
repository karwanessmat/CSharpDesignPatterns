namespace Adapter10Demo.Framework
{
    public class Dashboard(Spreadsheet document)
    {
        public void Render(IGraphic graphic)
        {
            graphic.Generate(document);
        }
    }
}