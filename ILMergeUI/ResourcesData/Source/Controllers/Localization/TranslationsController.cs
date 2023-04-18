using ILMergeUI.ResourcesData.Source.Core;
using System.Windows.Forms;

namespace ILMergeUI.ResourcesData.Source.Controllers.Localization
{
	public class TranslationsController
	{
		public string Translation_Get(string String_Key, string String_Language)
		{
			if (Classes.Class_LocalizationController.Dictionary_Localization.TryGetValue(String_Key, out string[] Strings_Translations))
			{ return String_Language == "English" ? Strings_Translations[0] : Strings_Translations[1]; }

			return String_Key;
		}

		private void Controls_Translate(Control Form_Translation)
		{
			foreach (Control Control_Translation in Form_Translation.Controls)
			{
				string String_Key = $"{Form_Translation.FindForm().Name.Replace(" ", string.Empty)}_{Control_Translation.Name}";
				string String_Translation = Translation_Get(String_Key, Classes.Class_SavedData.String_Language);

				if (String_Translation != String_Key)
				{
					try { Control_Translation.Text = String_Translation; }
					catch { }
				}

				if (Control_Translation.HasChildren)
				{ Controls_Translate(Control_Translation); }
			}
		}

		public void Forms_Translate()
		{
			foreach (Form Form_Translation in Application.OpenForms)
			{ Controls_Translate(Form_Translation); }
		}
	}
}