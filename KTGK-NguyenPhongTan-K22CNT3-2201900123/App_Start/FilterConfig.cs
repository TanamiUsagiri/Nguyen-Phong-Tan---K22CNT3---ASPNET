using System.Web;
using System.Web.Mvc;

namespace KTGK_NguyenPhongTan_K22CNT3_2201900123
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
