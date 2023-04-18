using ILMergeUI.ResourcesData.Source.Core;
using System.IO;

namespace ILMergeUI.ResourcesData.Source.Managers
{
	public class SavesManager
	{
		public void Data_Save()
		{
			string String_SaveDirectory = Classes.Class_SavedData.String_SaveDirectory;

			if (!Directory.Exists(String_SaveDirectory))
			{ Directory.CreateDirectory(String_SaveDirectory); }

			Classes.Class_PathController.Path_Save();
			Classes.Class_SavesController.Data_Save();
		}

		public void Data_Load()
		{
			try { Classes.Class_SavesController.Data_Load(); }
			catch
			{
				try
				{
					Classes.Class_PathController.Path_Load();
					Classes.Class_SavesController.Data_Load();
				} catch { }
			}
		}

		public void Directory_Delete(string String_Directory, bool Bool_PathDelete)
		{
			if (Directory.Exists(Classes.Class_SavedData.String_SaveDirectory))
			{ Classes.Class_SavesController.Directory_Delete(String_Directory, Bool_PathDelete); }
		}
	}
}