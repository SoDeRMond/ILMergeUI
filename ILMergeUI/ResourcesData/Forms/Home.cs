using ILMergeUI.ResourcesData.Source.Root;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System;
using TheArtOfDev.HtmlRenderer.WinForms;
using CommonMark;

namespace ILMergeUI.ResourcesData.Forms
{
	public partial class Home : Form
	{
		private readonly HtmlLabel HtmlLabel_Content = new HtmlLabel
		{
			BackColor = Classes.Class_Colors.Color_BackHome,
			AutoSize = true,
			MaximumSize = new Size(746, 0),
			MinimumSize = new Size(746, 0),
			Padding = new Padding(4, 2, 4, 2)
		};


		private const string _UpdateStatus = "Home_Label_UpdateStatus_";


		public Home()
		{ InitializeComponent(); }

		private void Translate_Get(string String_UpdateStatus, string String_Content)
		{
			string String_Language = Classes.Class_SavedData.String_Language;

			string String_Body = Classes.Class_LocalizationManager.Translation_Get(String_Content, String_Language);
			String_Body = (String_Body == String_Content) ? CommonMarkConverter.Convert(Classes.Class_UpdatesManager.Body_Get()) : String_Body;

			Label_UpdateStatus.Text = Classes.Class_LocalizationManager.Translation_Get(String_UpdateStatus, String_Language);
			HtmlLabel_Content.Text = $"<div>{String_Body}</div><style>div {{ color: #FFFFFF; }} p {{ margin: 0px 0px 8px 0px; }}</style>"
				.Replace($"</li>\r\n<li>\r\n<p>", "</li><br><li><p>");
		}

		private async void Program_Update()
		{
			int Int_UpdateStatus = await Classes.Class_UpdatesManager.Status_Get();

			if (Int_UpdateStatus == 0) { Translate_Get($"{_UpdateStatus}NoGitHubConnection", $"Home_HtmlLabel_Content_FailedToLoadChangeLog"); }
			else if (Int_UpdateStatus == 1) { Translate_Get($"{_UpdateStatus}FailedGetLatestVersion", $"Home_HtmlLabel_Content_FailedToLoadChangeLog"); }
			else if (Int_UpdateStatus == 2) { Translate_Get($"{_UpdateStatus}YouUsingLatestVersionProgram", string.Empty); }

			else
			{
				if (Classes.Class_SavedData.Int_AutoProgramUpdates == 0)
				{ Update_DownloadAndRun(); }

				else
				{
					Translate_Get($"{_UpdateStatus}ProgramUpdateAvailable", string.Empty);

					Button_DownloadAndRun.BackColor = Classes.Class_Colors.Color_BackHome;
					Button_DownloadAndRun.Enabled = true;
				}
			}
		}

		private void Content_Scroll(int Int_MouseDelta)
		{
			int Int_LimitPoint = (int)Math.Ceiling((float)(HtmlLabel_Content.Size.Height - Panel_Content.Size.Height));

			if (Int_MouseDelta > 0 && HtmlLabel_Content.Location.Y < 0)
			{ HtmlLabel_Content.Top += 36; }

			else if (Int_MouseDelta < 0 && HtmlLabel_Content.Location.Y > -Int_LimitPoint)
			{ HtmlLabel_Content.Top -= 36; }
		}

		private async void Update_DownloadAndRun()
		{
			Translate_Get($"{_UpdateStatus}DownloadingUpdate", string.Empty);

			try { await Classes.Class_UpdatesManager.Update_DownloadAndRun(); }
			catch { Program_Update(); }
		}

		private void GroupBox_ProgramUpdate_TextChanged(object Object_GroupBox, EventArgs EventArgs_TextChanged)
		{ Program_Update(); }

		private void HtmlLabel_Content_MouseWheel(object Object_Label, MouseEventArgs MouseEventArgs_MouseWheel)
		{ Content_Scroll(MouseEventArgs_MouseWheel.Delta); }

		private void Button_DownloadAndRun_Click(object Object_Button, EventArgs EventArgs_Click)
		{ Update_DownloadAndRun(); }

		private void LinkLabel_GitHub_LinkClicked(object Object_LinkLabel, LinkLabelLinkClickedEventArgs LinkLabelLinkClickedEventArgs_LinkClicked)
		{ Process.Start($"https://github.com/{Application.CompanyName}/{Application.ProductName}".Replace(" ", string.Empty)); }

		private void Form_Home_Load(object Object_Form, EventArgs EventArgs_Load)
		{
			HtmlLabel_Content.MouseWheel += new MouseEventHandler(HtmlLabel_Content_MouseWheel);
			Button_DownloadAndRun.BackColor = Color.Silver;

			Program_Update();
		}

		private void Form_Home_Shown(object Object_Form, EventArgs EventArgs_Shown)
		{
			Classes.Class_LocalizationManager.Forms_Translate();
			Panel_Content.Controls.Add(HtmlLabel_Content);
		}

		private void Form_Home_SizeChanged(object Object_Form, EventArgs EventArgs_SizeChanged)
		{
			HtmlLabel_Content.MaximumSize = new Size(Panel_Content.Size.Width, HtmlLabel_Content.MaximumSize.Height);
			HtmlLabel_Content.MinimumSize = new Size(Panel_Content.Size.Width, HtmlLabel_Content.MinimumSize.Height);

			HtmlLabel_Content.Location = new Point(HtmlLabel_Content.Location.X, 0);
		}
	}
}