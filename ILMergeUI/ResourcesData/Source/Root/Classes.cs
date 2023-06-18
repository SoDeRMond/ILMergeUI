using ILMergeUI.ResourcesData.Source.Controllers.Localization;
using ILMergeUI.ResourcesData.Source.Controllers.Saves;
using ILMergeUI.ResourcesData.Source.Functions.Merge;
using ILMergeUI.ResourcesData.Source.Controllers;
using ILMergeUI.ResourcesData.Source.Managers;
using ILMergeUI.ResourcesData.Source.Data;

namespace ILMergeUI.ResourcesData.Source.Root
{
	public static class Classes
	{
		public static AdditionalMethods Class_AdditionalMethods = new AdditionalMethods();
		public static SavedData Class_SavedData = new SavedData();
		public static Colors Class_Colors = new Colors();


		public static StartMerging Class_StartMerging = new StartMerging();


		public static LocalizationManager Class_LocalizationManager = new LocalizationManager();
		public static UpdatesManager Class_UpdatesManager = new UpdatesManager();
		public static SavesManager Class_SavesManager = new SavesManager();


		public static LocalizationController Class_LocalizationController = new LocalizationController();
		public static TranslationsController Class_TranslationsController = new TranslationsController();


		public static UpdatesController Class_UpdatesController = new UpdatesController();
		public static SavesController Class_SavesController = new SavesController();
		public static PathController Class_PathController = new PathController();
	}
}