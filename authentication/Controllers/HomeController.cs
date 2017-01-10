using System.Web.Mvc;
using System.Web.Security;

namespace authentication.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost] // 未加註記，會產生無法判斷要處理哪一個ActionResult
        public ActionResult Index(string name)
        {
           
            if (name == "123")
            {
                FormsAuthentication.SetAuthCookie(name, false);
              
                return RedirectToAction("秘密");
               
            }
            return View();
        }
        [Authorize]
        public ActionResult 秘密()
        {
           FormsAuthentication.SignOut();
            return View();
        }
    }
}