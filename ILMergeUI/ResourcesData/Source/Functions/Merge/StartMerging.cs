using ILMergeUI.ResourcesData.Source.Root;
using ILMergeUI.Properties;
using System.Windows.Forms;
using System.IO;

namespace ILMergeUI.ResourcesData.Source.Functions.Merge
{
	public class StartMerging
	{
		private const string _ILMerge = "ILMerge.exe";


		public void Merge_Start(string String_OutputPath, string String_Libraries)
		{
			File.WriteAllBytes(Path.Combine(Application.StartupPath, _ILMerge), Resources.ILMerge);
			File.WriteAllBytes(Path.Combine(Application.StartupPath, "System.Compiler.dll"), Resources.System_Compiler);

			Classes.Class_AdditionalMethods.Process_Start
				(_ILMerge, $"/out:\"{String_OutputPath}\" \"{Classes.Class_SavedData.String_InputPath}\" {String_Libraries}");
		}

		public void Temp_Delete(string String_OutputPath)
		{
			File.Delete(_ILMerge);
			File.Delete("System.Compiler.dll");

			if (Classes.Class_SavedData.Int_SavingFileAfterMerging == 1)
			{ File.Delete($"{String_OutputPath.Replace(".exe", string.Empty)}.pdb"); }
		}
	}
}