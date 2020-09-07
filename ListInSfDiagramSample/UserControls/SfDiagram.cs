using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using Syncfusion.UI.Xaml.Diagram;

namespace ListInSfDiagramSample.UserControls
{
    public class SfDiagram : Syncfusion.UI.Xaml.Diagram.SfDiagram
    {
        public static DependencyProperty PageHeightProperty = DependencyProperty.Register(
            nameof(PageHeight),
            typeof(double),
            typeof(SfDiagram),
            new PropertyMetadata(new PageSettings().PageHeight)
        );
        public static DependencyProperty PageWidthProperty = DependencyProperty.Register(
            nameof(PageWidth),
            typeof(double),
            typeof(SfDiagram),
            new PropertyMetadata(new PageSettings().PageWidth)
        );
        public static DependencyProperty PageBackgroundProperty = DependencyProperty.Register(
            nameof(PageBackground),
            typeof(Brush),
            typeof(SfDiagram),
            new PropertyMetadata(new PageSettings().PageBackground)
        );
        public static DependencyProperty ScrollLimitProperty = DependencyProperty.Register(
            nameof(ScrollLimit),
            typeof(ScrollLimit),
            typeof(SfDiagram),
            new PropertyMetadata(new ScrollSettings().ScrollLimit)
        );
        public static DependencyProperty AutoScrollLimitProperty = DependencyProperty.Register(
            nameof(AutoScrollLimit),
            typeof(ScrollLimit),
            typeof(SfDiagram),
            new PropertyMetadata(new ScrollSettings().AutoScrollLimit)
        );
        public static DependencyProperty DragLimitProperty = DependencyProperty.Register(
            nameof(DragLimit),
            typeof(ScrollLimit),
            typeof(SfDiagram),
            new PropertyMetadata(new ScrollSettings().DragLimit)
        );
        public Brush PageBackground
        {
            get => (Brush)GetValue(PageBackgroundProperty);
            set
            {
                SetValue(PageBackgroundProperty, value);
                if (PageSettings is PageSettings)
                    PageSettings.PageBackground = value;
                OnPropertyChanged(nameof(PageBackground));
                if (PageSettings is PageSettings)
                    OnPropertyChanged(nameof(PageSettings));
            }
        }
        public double PageHeight
        {
            get => (double)GetValue(PageHeightProperty);
            set
            {
                SetValue(PageHeightProperty, value);
                if (PageSettings is PageSettings)
                    PageSettings.PageHeight = value;
                OnPropertyChanged(nameof(PageHeight));
                if (PageSettings is PageSettings)
                    OnPropertyChanged(nameof(PageSettings));
            }
        }
        public double PageWidth
        {
            get => (double)GetValue(PageWidthProperty);
            set
            {
                SetValue(PageWidthProperty, value);
                if (PageSettings is PageSettings)
                    PageSettings.PageWidth = value;
                OnPropertyChanged(nameof(PageWidth));
                if (PageSettings is PageSettings)
                    OnPropertyChanged(nameof(PageSettings));
            }
        }
        public ScrollLimit ScrollLimit
        {
            get => (ScrollLimit)GetValue(ScrollLimitProperty);
            set
            {
                SetValue(ScrollLimitProperty, value);
                if (ScrollSettings is ScrollSettings)
                    ScrollSettings.ScrollLimit = value;
                OnPropertyChanged(nameof(ScrollLimit));
                if (ScrollSettings is ScrollSettings)
                    OnPropertyChanged(nameof(ScrollSettings));
            }
        }
        public ScrollLimit AutoScrollLimit
        {
            get => (ScrollLimit)GetValue(AutoScrollLimitProperty);
            set
            {
                SetValue(AutoScrollLimitProperty, value);
                if (ScrollSettings is ScrollSettings)
                    ScrollSettings.AutoScrollLimit = value;
                OnPropertyChanged(nameof(AutoScrollLimit));
                if (ScrollSettings is ScrollSettings)
                    OnPropertyChanged(nameof(ScrollSettings));
            }
        }
        public ScrollLimit DragLimit
        {
            get => (ScrollLimit)GetValue(DragLimitProperty);
            set
            {
                SetValue(DragLimitProperty, value);
                if (ScrollSettings is ScrollSettings)
                    ScrollSettings.DragLimit = value;
                OnPropertyChanged(nameof(DragLimit));
                if (ScrollSettings is ScrollSettings)
                    OnPropertyChanged(nameof(ScrollSettings));
            }
        }
        protected override void OnInitialized(System.EventArgs e)
        {
            base.OnInitialized(e);
            PageSettings.PageBackground = PageBackground;
            PageSettings.PageHeight = PageHeight;
            PageSettings.PageWidth = PageWidth;
            ScrollSettings.ScrollLimit = ScrollLimit;
            ScrollSettings.AutoScrollLimit = AutoScrollLimit;
            ScrollSettings.DragLimit = DragLimit;

        }
    }
}
