using System.Windows.Media;
using Syncfusion.UI.Xaml.Diagram;

namespace ListInSfDiagramSample.UserControls
{
    public class SfDiagram : Syncfusion.UI.Xaml.Diagram.SfDiagram
    {
        public SfDiagram() : base()
        {
            PageSettings = new PageSettings
            {
                PageBackground = Brushes.Transparent,
                PageHeight = 100,
                PageWidth = 100,
            };
            ScrollSettings = new ScrollSettings
            {
                ScrollLimit = ScrollLimit.Diagram,
                AutoScrollLimit = ScrollLimit.Diagram,
                DragLimit = ScrollLimit.Diagram,
            };
        }
    }
}
