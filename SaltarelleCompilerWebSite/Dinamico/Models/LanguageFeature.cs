using Dinamico;
using Dinamico.Models;
using N2;
using N2.Details;
using N2.Integrity;
using N2.Persistence;
using N2.Definitions;
using System.Web.UI.WebControls;

namespace Dinamico.Models
{
	[PageDefinition]
	[WithEditableTitle]
	[RestrictParents(typeof(LanguageFeaturesListPage))]
	public class LanguageFeature : ContentItem
	{
		/// <summary>
		/// Image used on the page and on listings.
		/// </summary>
		//[EditableMediaUpload(PreferredSize = "wide")]
		//[Persistable(Length = 256)] // to minimize select+1
		//public virtual string Icon { get; set; }

		/// <summary>
		/// Image used on the page and on listings.
		/// </summary>
		[EditableText(TextMode = TextBoxMode.SingleLine, MaxLength = 100)]
		public virtual string Status { get; set; }

		[EditableFreeTextArea]
		[DisplayableTokens]
		public virtual string Description { get; set; }

		[EditableText(TextMode = TextBoxMode.MultiLine, Columns = 80, Rows = 10, ValidationExpression = ".*{0,1000}", ValidationMessage = "Max 1000 characters")]
		[DisplayableTokens]
		public virtual string CSharp { get; set; }

		[EditableText(TextMode = TextBoxMode.MultiLine, Columns = 80, Rows = 10, ValidationExpression = ".*{0,1000}", ValidationMessage = "Max 1000 characters")]
		[DisplayableTokens]
		public virtual string JavaScript { get; set; }

		[EditableText(TextMode = TextBoxMode.MultiLine, Columns = 80, Rows = 10, ValidationExpression = ".*{0,1000}", ValidationMessage = "Max 1000 characters")]
		[DisplayableTokens]
		public virtual string Output { get; set; }
	}
}