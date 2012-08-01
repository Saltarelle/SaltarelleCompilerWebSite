using System.Web.Mvc;
using N2.Web;
using N2.Web.Mvc;

namespace Dinamico.Controllers
{
	[Controls(typeof(Models.LanguageFeature))]
    public class LanguageFeatureController : ContentController<Models.LanguageFeature>
    {

        public override ActionResult Index()
        {
			return View(CurrentItem.TemplateKey, CurrentItem);
        }
    }
}
