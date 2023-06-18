using ILMergeUI.ResourcesData.Source.Root;
using ILMergeUI.ResourcesData.Source.Data;
using System.Text.Json;
using System.IO;

namespace ILMergeUI.ResourcesData.Source.Controllers.Saves
{
	public class SavesController
	{
		private readonly JsonSerializerOptions JsonSerializerOptions_Saving = new JsonSerializerOptions
		{ WriteIndented = true };


		private readonly string String_SavePath = Path.Combine($"{Classes.Class_SavedData.String_SaveDirectory}\\{Classes.Class_SavedData.String_SaveName}");


		public void Data_Save()
		{
			string String_SerializeData = JsonSerializer.Serialize(Classes.Class_SavedData, JsonSerializerOptions_Saving);
			File.WriteAllText(String_SavePath, String_SerializeData);
		}

		public void Data_Load()
		{
			string String_SavedData = File.ReadAllText(String_SavePath);
			Classes.Class_SavedData = JsonSerializer.Deserialize<SavedData>(String_SavedData);
		}

		public void Directory_Delete(string String_Directory, bool Bool_PathDelete)
		{
			string[] Strings_Files = Directory.GetFiles(String_Directory);
			bool Bool_DirectoryDelete = true;

			foreach (string String_File in Strings_Files)
			{
				if (Path.GetExtension(String_File) != ".json")
				{ Bool_DirectoryDelete = false; }
			}

			if (Bool_DirectoryDelete == true)
			{
				if (Bool_PathDelete == true) { Classes.Class_PathController.Path_Delete(); }
				Directory.Delete(String_Directory, true);
			}
		}
	}
}