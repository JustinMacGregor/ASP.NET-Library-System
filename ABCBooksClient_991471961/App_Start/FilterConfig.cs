using System.Web;
using System.Web.Mvc;

namespace ABCBooksClient_991471961
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
