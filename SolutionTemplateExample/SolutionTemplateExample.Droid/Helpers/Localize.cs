using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SolutionTemplateExample.Droid.Helpers;
using SolutionTemplateExample.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(Localize))]
namespace SolutionTemplateExample.Droid.Helpers
{
    public class Localize : ILocalize
    {
        public System.Globalization.CultureInfo GetCurrentCultureInfo()
        {
            var androidLocale = Java.Util.Locale.Default;

            //var netLanguage = androidLocale.Language.Replace ("_", "-");
            var netLanguage = androidLocale.ToString().Replace("_", "-");

            //var netLanguage = androidLanguage.Replace ("_", "-");
            Console.WriteLine("android:" + androidLocale.ToString());
            Console.WriteLine("net:" + netLanguage);

            Console.WriteLine(Thread.CurrentThread.CurrentCulture);
            Console.WriteLine(Thread.CurrentThread.CurrentUICulture);

            return new System.Globalization.CultureInfo(netLanguage);
        }

        public void SetLocale()
        {
            var androidLocale = Java.Util.Locale.Default; // user's preferred locale
            var netLocale = androidLocale.ToString().Replace("_", "-");
            var ci = new System.Globalization.CultureInfo(netLocale);

            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }
    }
}