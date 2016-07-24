using SolutionTemplateExample.iOS.Renders;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(TabbedPage), typeof(TabbedPageCustom))]
namespace SolutionTemplateExample.iOS.Renders
{
    public class TabbedPageCustom : TabbedRenderer
    {
        public TabbedPageCustom()
        {
            TabBar.TintColor = UIColor.FromRGB(112, 66, 20);
            TabBar.BarTintColor = UIColor.FromRGB(112, 66, 20);
            TabBar.BackgroundColor = UIColor.FromRGB(112, 66, 20);
            TabBar.SelectedImageTintColor = UIColor.White;
        }
    }
}
