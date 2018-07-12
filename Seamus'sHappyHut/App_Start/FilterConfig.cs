using System.Web;
using System.Web.Mvc;

namespace Seamus_sHappyHut
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
