using System.Web;
using System.Web.Mvc;
using StudentViewer.CustomFilters;

namespace StudentViewer
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
           
            
        }
    }
}