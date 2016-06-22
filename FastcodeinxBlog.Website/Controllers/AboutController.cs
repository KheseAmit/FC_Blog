using System.Web.Mvc;

namespace FastcodeinxBlog.Website.Controllers
{
    /// <summary>
    /// Controller for the about.
    /// </summary>
    public partial class AboutController : Controller
    {
        /// <summary>
        /// Shows the about.
        /// </summary>
        /// <returns>The about view.</returns>
        public virtual ActionResult Index()
        {
            return this.View();
        }
    }
}
