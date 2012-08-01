using System.Web.Mvc;
using N2.Web;
using N2.Web.Mvc;

namespace Dinamico.Controllers
{
	[Controls(typeof(Models.LanguageFeaturesListPage))]
    public class LanguageFeaturesListController : ContentController<Models.LanguageFeaturesListPage>
    {

        public override ActionResult Index()
        {
			return View(CurrentItem.TemplateKey, CurrentItem);
        }
    }
}
