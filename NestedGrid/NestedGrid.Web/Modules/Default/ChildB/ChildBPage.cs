using Microsoft.AspNetCore.Mvc;
using Serenity.Web;

namespace NestedGrid.Default.Pages 
{
    [PageAuthorize(typeof(ChildBRow))]
    public class ChildBController : Controller
    {
        [Route("Default/ChildB")]
        public ActionResult Index()
        {
            return View("~/Modules/Default/ChildB/ChildBIndex.cshtml");
        }
    }
}