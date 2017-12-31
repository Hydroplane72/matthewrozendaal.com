using System.Web.Mvc;

namespace matthewrozendaal.com.Areas.KidsList
{
    public class KidsListAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "KidsList";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "KidsList_default",
                "KidsList/{controller}/{action}/{id}",
                new { controller = "Account", action = "SantaLogin", id = UrlParameter.Optional },
                namespaces: new[] { "matthewrozendaal.com.Areas.KidsList.Controllers" }
                );
        }
    }
}