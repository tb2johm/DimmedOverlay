using System.Windows;
using System.Windows.Controls;

namespace DimmedOverlay
{
    /// <summary>
    /// Interaction logic for DimmedOverlayControl.xaml
    /// </summary>
    public partial class DimmedOverlayControl : UserControl
    {


        public bool Dimmed
        {
            get { return (bool)GetValue(DimmedProperty); }
            set { SetValue(DimmedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Dimmed.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DimmedProperty =
            DependencyProperty.Register("Dimmed", typeof(bool), typeof(DimmedOverlayControl), new PropertyMetadata(false));

        

        public DimmedOverlayControl()
        {
            InitializeComponent();
        }
    }
}
