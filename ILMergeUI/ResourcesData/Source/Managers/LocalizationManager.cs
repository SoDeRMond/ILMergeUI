using ILMergeUI.ResourcesData.Source.Core;

namespace ILMergeUI.ResourcesData.Source.Managers
{
	public class LocalizationManager
	{
		public void Localization_Load()
		{ Classes.Class_LocalizationController.Localization_Load(); }

		public string Translation_Get(string String_Key, string String_Language)
		{ return Classes.Class_TranslationsController.Translation_Get(String_Key, String_Language); }

		public void Forms_Translate()
		{ Classes.Class_TranslationsController.Forms_Translate(); }
	}
}