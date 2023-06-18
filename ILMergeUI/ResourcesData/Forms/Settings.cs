using ILMergeUI.ResourcesData.Source.Root;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System;

namespace ILMergeUI.ResourcesData.Forms
{
	public partial class Settings : Form
	{
		public Settings()
		{ InitializeComponent(); }

		private void UI_Refresh()
		{
			TextBox_SavePath.Text = $"{Classes.Class_SavedData.String_SaveDirectory}\\{Classes.Class_SavedData.String_SaveName}".Replace("\\", "/");

			if (Classes.Class_SavedData.Int_AutoProgramUpdates == 0) { RadioButton_AutoProgramUpdates_Enable.Checked = true; }
			else { RadioButton_AutoProgramUpdates_Disable.Checked = true; }

			if (Classes.Class_SavedData.Int_SavingFileAfterMerging == 0) { RadioButton_SavingFileAfterMerging_Enable.Checked = true; }
			else { RadioButton_SavingFileAfterMerging_Disable.Checked = true; }
		}

		private void SavePath_ShowDialog()
		{
			string String_Language = Classes.Class_SavedData.String_Language;

			SaveFileDialog_SavePath.InitialDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
			SaveFileDialog_SavePath.Title = Classes.Class_LocalizationManager.Translation_Get("Settings_SaveFileDialog_SavePath_Title", String_Language);
			SaveFileDialog_SavePath.Filter = Classes.Class_LocalizationManager.Translation_Get("Settings_SaveFileDialog_SavePath_Filter", String_Language);
			SaveFileDialog_SavePath.FileName = "SavedData";

			if (SaveFileDialog_SavePath.ShowDialog() == DialogResult.OK)
			{
				Classes.Class_SavedData.String_OldSaveName = Classes.Class_SavedData.String_SaveName;
				Classes.Class_SavedData.String_OldSaveDirectory = Classes.Class_SavedData.String_SaveDirectory;

				Classes.Class_SavedData.String_SaveDirectory = Path.GetDirectoryName(SaveFileDialog_SavePath.FileName);
				Classes.Class_SavedData.String_SaveName = Path.GetFileName(SaveFileDialog_SavePath.FileName);

				Classes.Class_SavesManager.Data_Save();
				Classes.Class_SavesManager.Directory_Delete(Classes.Class_SavedData.String_OldSaveDirectory, false);
			}
		}

		private void TextBox_SavePath_DoubleClick(object Object_TextBox, EventArgs EventArgs_DoubleClick)
		{
			SavePath_ShowDialog();
			UI_Refresh();
		}

		private void RadioButtons_AutoProgramUpdates_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			Classes.Class_SavedData.Int_AutoProgramUpdates = ((RadioButton)Object_RadioButton).TabIndex;
			Classes.Class_SavesManager.Data_Save();
		}

		private void Button_DeleteSavedProgramFiles_Click(object Object_Button, EventArgs EventArgs_Click)
		{ Classes.Class_SavesManager.Directory_Delete(Classes.Class_SavedData.String_SaveDirectory, true); }

		private void RadioButtons_SavingFileAfterMerging_Click(object Object_RadioButton, EventArgs EventArgs_Click)
		{
			Classes.Class_SavedData.Int_SavingFileAfterMerging = ((RadioButton)Object_RadioButton).TabIndex;
			Classes.Class_SavesManager.Data_Save();
		}

		private void Form_Settings_Load(object Object_Form, EventArgs EventArgs_Load)
		{ UI_Refresh(); }

		private void Form_Settings_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{ Classes.Class_LocalizationManager.Forms_Translate(); }

		private void Form_Settings_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{ Panel_Left.Size = new Size((Panel_Left.Size.Width + Panel_Right.Size.Width) / 2, Panel_Left.Size.Height); }
	}
}