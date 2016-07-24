using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SolutionTemplateExample.Controls
{
    public class HanselmanNavigationPage : NavigationPage
    {
        public HanselmanNavigationPage(Page root) : base(root)
        {
            Init();
        }

        public HanselmanNavigationPage()
        {
            Init();
        }

        void Init()
        {

            BarBackgroundColor = Color.FromHex("#795548");
            BarTextColor = Color.White;
        }
    }
}
