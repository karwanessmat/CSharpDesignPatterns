using Adapter10Demo.Plugins;

namespace Adapter10Demo.Framework
{
    public class EarthAdapter(Earth earth) : IGraphic
    {
        public void Generate(Spreadsheet doc)
        {
            earth.Render(doc);
        }
    }
}
