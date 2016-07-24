using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionTemplateExample.Helpers;
using SolutionTemplateExample.Model.MasterDetailPage;
using SolutionTemplateExample.Resx;
using Xamarin.Forms;

namespace SolutionTemplateExample.Pages.DetailPage
{
    public partial class MenuPage : ContentPage
    {
        RootPage root;
        List<HomeMenuItem> menuItems;
        public MenuPage(RootPage root)
        {

            this.root = root;
            InitializeComponent();

            BackgroundColor = Color.FromHex("#795548");
            // ListViewMenu.BackgroundColor = Color.FromHex("#F5F5F5");
            BindingContext = new BaseViewModel
            {
                Title = AppResources.MenuTitle,
                Subtitle = " ",
                Icon = "icon.png"
            };

            ListViewMenu.ItemsSource = menuItems = new List<HomeMenuItem>
                {
                    new HomeMenuItem { Title = AppResources.MenuAboutApp, MenuType = MenuType.AboutApp, Icon ="icon.png" },
                };

            ListViewMenu.SelectedItem = menuItems[0];

            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (ListViewMenu.SelectedItem == null)
                    return;

                await this.root.NavigateAsync(((HomeMenuItem)e.SelectedItem).MenuType);
            };
        }
    }
}
