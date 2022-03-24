using System.Web;
using System.Web.Mvc;

namespace _1911066528_BuiXuanHai_Bigschool
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
