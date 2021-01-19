using System.Web;
using System.Web.Mvc;

namespace Team_WASD_GSSMSClient
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
