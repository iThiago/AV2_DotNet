using System.Web;
using System.Web.Mvc;

namespace Lilianne_Lameira_AV1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
