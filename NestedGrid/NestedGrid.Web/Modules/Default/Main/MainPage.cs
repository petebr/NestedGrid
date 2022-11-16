using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace NestedGrid.Default.Pages 
{
    [PageAuthorize(typeof(MainRow))]
    public class MainController : Controller
    {
        [Route("Default/Main")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/Main/MainIndex.cshtml");
        }
    }
}