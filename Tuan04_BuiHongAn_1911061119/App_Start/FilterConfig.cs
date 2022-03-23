using System.Web;
using System.Web.Mvc;

namespace Tuan04_BuiHongAn_1911061119
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
