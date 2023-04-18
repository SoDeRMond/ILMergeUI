using ILMergeUI.ResourcesData.Source.Core;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;

namespace ILMergeUI.ResourcesData.Source.Controllers.Saves
{
	public class PathController
	{
		private readonly string _SOFTWARE = Path.Combine($"SOFTWARE\\{Application.ProductName}");


		public void Path_Save()
		{
			using (RegistryKey RegistryKey_Path = Registry.CurrentUser.CreateSubKey(_SOFTWARE))
			{
				RegistryKey_Path.SetValue("String_SaveDirectory", Classes.Class_SavedData.String_SaveDirectory);
				RegistryKey_Path.SetValue("String_SaveName", Classes.Class_SavedData.String_SaveName);
			}
		}

		public void Path_Load()
		{
			using (RegistryKey RegistryKey_Path = Registry.CurrentUser.OpenSubKey(_SOFTWARE))
			{
				Classes.Class_SavedData.String_SaveDirectory = RegistryKey_Path.GetValue("String_SaveDirectory").ToString();
				Classes.Class_SavedData.String_SaveName = RegistryKey_Path.GetValue("String_SaveName").ToString();
			}
		}

		public void Path_Delete()
		{ Registry.CurrentUser.DeleteSubKey(_SOFTWARE); }
	}
}