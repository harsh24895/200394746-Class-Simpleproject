using System.Web;
using System.Web.Mvc;

namespace _200394746_Class_Simplepro
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
