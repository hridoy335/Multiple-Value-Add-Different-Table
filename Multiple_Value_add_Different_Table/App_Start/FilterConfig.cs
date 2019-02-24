using System.Web;
using System.Web.Mvc;

namespace Multiple_Value_add_Different_Table
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
