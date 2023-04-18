using System.Windows.Forms;
using System.IO;
using System;

namespace ILMergeUI.ResourcesData.Source.Data
{
	public class SavedData
	{
		public string String_Language { get; set; } = "English";


		public string String_InputPath { get; set; } = Path.Combine(Application.StartupPath + "\\Input.exe");
		public string String_LibrariesPath { get; set; } = Application.StartupPath;

		public string String_OutputDirectory { get; set; } = Application.StartupPath;
		public string String_OutputName { get; set; } = "Output.exe";


		public string String_SaveDirectory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\{Application.ProductName}");
		public string String_SaveName { get; set; } = "SavedData.json";

		public string String_OldSaveDirectory { get; set; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + $"\\{Application.ProductName}");
		public string String_OldSaveName { get; set; } = "SavedData.json";


		public int Int_AutoProgramUpdates { get; set; } = 1;
		public int Int_SavingFileAfterMerging { get; set; } = 1;
	}
}