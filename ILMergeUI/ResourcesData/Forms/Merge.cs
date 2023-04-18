using ILMergeUI.ResourcesData.Source.Core;
using System.Windows.Forms;
using System.Drawing;
using System.Linq;
using System.IO;
using System;

namespace ILMergeUI.ResourcesData.Forms
{
	public partial class Merge : Form
	{
		public Merge()
		{ InitializeComponent(); }

		private void Libraries_Refresh()
		{
			ListBox_Libraries.Items.Clear();

			foreach (string String_Library in Directory.GetFiles(Classes.Class_SavedData.String_LibrariesPath, "*.dll"))
			{ ListBox_Libraries.Items.Add(Path.GetFileNameWithoutExtension(String_Library)); }
		}

		private void UI_Refresh()
		{
			TextBox_Input.Text = Classes.Class_SavedData.String_InputPath.Replace("\\", "/");
			TextBox_Output.Text = $"{Classes.Class_SavedData.String_OutputDirectory}\\{Classes.Class_SavedData.String_OutputName}".Replace("\\", "/");
			TextBox_Libraries.Text = Classes.Class_SavedData.String_LibrariesPath.Replace("\\", "/");

			if (Directory.Exists(Classes.Class_SavedData.String_LibrariesPath))
			{ Libraries_Refresh(); }
		}

		private void Input_ShowDialog()
		{
			string String_Language = Classes.Class_SavedData.String_Language;

			OpenFileDialog_Input.InitialDirectory = Application.StartupPath;
			OpenFileDialog_Input.Title = Classes.Class_LocalizationManager.Translation_Get("Merge_OpenFileDialog_Input_Title", String_Language);
			OpenFileDialog_Input.Filter = Classes.Class_LocalizationManager.Translation_Get("Merge_OpenFileDialog_Input_Filter", String_Language);

			if (OpenFileDialog_Input.ShowDialog() == DialogResult.OK)
			{
				Classes.Class_SavedData.String_InputPath = Path.GetFullPath(OpenFileDialog_Input.FileName);

				Classes.Class_SavesManager.Data_Save();
				UI_Refresh();
			}
		}

		private void Output_ShowDialog()
		{
			string String_Language = Classes.Class_SavedData.String_Language;

			SaveFileDialog_Output.InitialDirectory = Application.StartupPath;
			SaveFileDialog_Output.Title = Classes.Class_LocalizationManager.Translation_Get("Merge_SaveFileDialog_Output_Title", String_Language);
			SaveFileDialog_Output.Filter = Classes.Class_LocalizationManager.Translation_Get("Merge_SaveFileDialog_Output_Filter", String_Language);
			SaveFileDialog_Output.FileName = "Output";

			if (SaveFileDialog_Output.ShowDialog() == DialogResult.OK)
			{
				Classes.Class_SavedData.String_OutputDirectory = Path.GetDirectoryName(SaveFileDialog_Output.FileName);
				Classes.Class_SavedData.String_OutputName = Path.GetFileName(SaveFileDialog_Output.FileName);

				Classes.Class_SavesManager.Data_Save();
				UI_Refresh();
			}
		}

		private void Libraries_ShowDialog()
		{
			FolderBrowserDialog_Libraries.Description = Classes.Class_LocalizationManager.Translation_Get("Merge_FolderBrowserDialog_Libraries_Description", Classes.Class_SavedData.String_Language);

			if (FolderBrowserDialog_Libraries.ShowDialog() == DialogResult.OK)
			{
				Classes.Class_SavedData.String_LibrariesPath = FolderBrowserDialog_Libraries.SelectedPath;

				Classes.Class_SavesManager.Data_Save();
				UI_Refresh();
			}
		}

		private void TextBox_Input_DoubleClick(object Object_TextBox, EventArgs EventArgs_DoubleClick)
		{ Input_ShowDialog(); }

		private void TextBox_Output_DoubleClick(object Object_TextBox, EventArgs EventArgs_DoubleClick)
		{ Output_ShowDialog(); }

		private void TextBox_Libraries_DoubleClick(object Object_TextBox, EventArgs EventArgs_DoubleClick)
		{ Libraries_ShowDialog(); }

		private void Button_RefreshList_Click(object Object_Button, EventArgs EventArgs_Click)
		{ UI_Refresh(); }

		private void Button_DeleteLibrary_Click(object Object_Button, EventArgs EventArgs_Click)
		{ ListBox_Libraries.Items.Remove(ListBox_Libraries.SelectedItem?.ToString()); }

		private void Button_StartMerging_Click(object Object_Button, EventArgs EventArgs_Click)
		{
			string String_OutputPath = Path.Combine($"{Classes.Class_SavedData.String_OutputDirectory}\\{Classes.Class_SavedData.String_OutputName}");
			string String_Libraries = string.Join(" ", ListBox_Libraries.Items.Cast<string>().Select(String_Library => $"{String_Library}.dll "));

			Classes.Class_StartMerging.Merge_Start(String_OutputPath, String_Libraries);
			Classes.Class_StartMerging.Temp_Delete(String_OutputPath);
		}

		private void Form_Merge_Load(object Object_Form, EventArgs EventArgs_Load)
		{ UI_Refresh(); }

		private void Form_Merge_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }

		private void Form_Merge_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{ Panel_Left.Size = new Size((Panel_Left.Size.Width + Panel_Right.Size.Width) / 2 + Panel_Right.Width / 4, Panel_Left.Size.Height); }
	}
}