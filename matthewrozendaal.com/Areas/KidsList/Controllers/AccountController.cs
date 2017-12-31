using System.Web.Mvc;

namespace matthewrozendaal.com.Controllers.Santa_Helper
{
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("SantaLogin");
        }
        // GET: Account
        /// <summary>
        /// When user clicks to go to the kids helperpage
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult SantaLogin()
        {
           // return RedirectToRoute("~/KidsList/Account/SantaLogin");
            return View("~/Areas/KidsList/Views/Account/SantaLogin.cshtml");
        }
        /// <summary>
        /// Log the user into the system
        ///  Authorize the user.
        /// </summary>
        /// <param name="formValues">The username and password form values.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SantaLogin(FormCollection formValues)
        {

            return View();
            //return RedirectToRoute("");
        }

        /// <summary>
        /// Creates the User Account
        /// </summary>
        /// <returns></returns>
        public ActionResult SantaCreate()
        {
            return View();
        }
    }
}