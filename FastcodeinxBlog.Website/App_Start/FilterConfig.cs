using System.Configuration;
using System.Web;
using System.Web.Mvc;

namespace FastcodeinxBlog.Website
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new FastcodeinxBlog.Common.Net.Mvc.HandleErrorAttribute());
            filters.Add(new FastcodeinxBlog.Common.Net.Mvc.Localization.LocalizeAttribute());
            filters.Add(new FastcodeinxBlog.Common.Net.PingBack.PingbackAttribute(ConfigurationManager.AppSettings["PingbackHandler"]));
        }
    }
}
