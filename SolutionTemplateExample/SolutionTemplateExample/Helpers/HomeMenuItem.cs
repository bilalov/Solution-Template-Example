

using SolutionTemplateExample.Model;

namespace SolutionTemplateExample.Helpers
{
    public enum MenuType
    {
        InputPage,
        AboutApp,
    }
    public class HomeMenuItem : BaseModel
    {
        public HomeMenuItem()
        {
            MenuType = MenuType.InputPage;
        }
        public string Icon { get; set; }
        public MenuType MenuType { get; set; }
    }
}
