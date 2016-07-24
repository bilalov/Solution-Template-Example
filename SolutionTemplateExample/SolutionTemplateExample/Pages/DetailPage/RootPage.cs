using System.Collections.Generic;
using System.Threading.Tasks;
using SolutionTemplateExample.Controls;
using SolutionTemplateExample.Helpers;
using SolutionTemplateExample.Model;
using SolutionTemplateExample.Model.MasterDetailPage;
using SolutionTemplateExample.Pages;
using SolutionTemplateExample.Pages.About;
using SolutionTemplateExample.Pages.DetailPage;

using Xamarin.Forms;

namespace SolutionTemplateExample.Pages.DetailPage
{
    public class RootPage : MasterDetailPage
    {
        public static bool IsUWPDesktop { get; set; }
        Dictionary<MenuType, NavigationPage> Pages { get; set; }
        public RootPage()
        {
            
            Pages = new Dictionary<MenuType, NavigationPage>();
            Master = new MenuPage(this);
            BindingContext = new BaseViewModel
            {
                Title = "d",
                Icon = "icon.png"
            };
            //setup home page
            NavigateAsync(MenuType.InputPage);
            InvalidateMeasure();
        }

        public RootPage(MenuType menuType)
        {

            Pages = new Dictionary<MenuType, NavigationPage>();
            Master = new MenuPage(this);
            BindingContext = new BaseViewModel
            {
                Title = "d",
                Icon = "icon.png"
            };
            //setup home page
            NavigateAsync(menuType);
            InvalidateMeasure();
        }


        public async Task NavigateAsync(MenuType id)
        {
            Page newPage;
            if (!Pages.ContainsKey(id))
            {

                switch (id)
                { 
                    case MenuType.AboutApp:
                        Pages.Add(id, new HanselmanNavigationPage(new AboutTabbedPage()));
                        break;
                    case MenuType.InputPage:
                        Pages.Add(id, new HanselmanNavigationPage(new HelloAppPage()));
                        break;
                }
            }

            newPage = Pages[id];
            if (newPage == null)
                return;

            //pop to root for Windows Phone
            if (Detail != null && Device.OS == TargetPlatform.WinPhone)
            {
                await Detail.Navigation.PopToRootAsync();
            }

            Detail = newPage;

            if (IsUWPDesktop)
                return;

            if (Device.Idiom != TargetIdiom.Tablet)
                IsPresented = false;
        }
    }
}
