using Dinamico;
using Dinamico.Models;
using N2;
using N2.Details;
using N2.Persistence;
using N2.Definitions;
using System.Web.UI.WebControls;

namespace Dinamico.Models
{
	/// <summary>
	/// Content page model used in several places:
	///  * It serves as base class for start page
	///  * It's the base for "template first" definitions located in /dinamico/default/views/contentpages/
	/// </summary>
	[PageDefinition]
	[WithEditableTemplateSelection(ContainerName = Defaults.Containers.Metadata)]
	public class LanguageFeaturesListPage : ContentPage
	{
		/// <summary>
		/// Text after the language feature list.
		/// </summary>
		[EditableFreeTextArea]
		[DisplayableTokens]
		public virtual string TextAfter { get; set; }
	}
}