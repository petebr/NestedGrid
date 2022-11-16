using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace NestedGrid.Default.Pages 
{
    [PageAuthorize(typeof(ChildARow))]
    public class ChildAController : Controller
    {
        [Route("Default/ChildA")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/ChildA/ChildAIndex.cshtml");
        }
    }
}