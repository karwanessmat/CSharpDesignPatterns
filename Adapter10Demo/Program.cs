using Adapter10Demo.Framework;
using Adapter10Demo.Plugins;

var dashboard = new Dashboard(new Spreadsheet());
dashboard.Render(new EarthAdapter(new Earth()));