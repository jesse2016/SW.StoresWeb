using GTDataImport.Filters;
using System.Web;
using System.Web.Mvc;

namespace GTDataImport
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }  
    }
}