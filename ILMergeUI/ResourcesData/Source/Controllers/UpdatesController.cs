using ILMergeUI.ResourcesData.Source.Root;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.IO;
using Octokit;

namespace ILMergeUI.ResourcesData.Source.Controllers
{
	public class UpdatesController
	{
		private readonly string String_CurrentVersion = Classes.Class_AdditionalMethods.Symbols_Remove(System.Windows.Forms.Application.ProductVersion);

		private readonly string String_CompanyName = System.Windows.Forms.Application.CompanyName;
		private readonly string String_ProductName = System.Windows.Forms.Application.ProductName.Replace(" ", string.Empty);


		private GitHubClient GitHubClient_Update;
		public Release Release_Latest;

		private string String_LatestVersion;


		private async Task<bool> Version_Check()
		{
			GitHubClient_Update = new GitHubClient(new ProductHeaderValue(String_ProductName));
			Release_Latest = await GitHubClient_Update.Repository.Release.GetLatest(String_CompanyName, String_ProductName);

			return String_CurrentVersion != Classes.Class_AdditionalMethods.Symbols_Remove(Release_Latest.TagName);
		}

		public async Task<int> Status_Get()
		{
			if (Classes.Class_AdditionalMethods.Connection_Check("GitHub.com") == false)
			{ return 0; }

			try { return await Version_Check() ? 3 : 2; }
			catch { return 1; }
		}

		public async Task Update_Download()
		{
			IReadOnlyList<ReleaseAsset> ReleaseAsset_All = await GitHubClient_Update.Repository.Release.GetAllAssets(String_CompanyName, String_ProductName, Release_Latest.Id);
			ReleaseAsset ReleaseAsset_Latest = ReleaseAsset_All.FirstOrDefault();

			using (WebClient WebClient_Update = new WebClient())
			{ WebClient_Update.DownloadFile(ReleaseAsset_Latest.BrowserDownloadUrl, $"{String_ProductName}_Latest.zip"); }

			Update_Run();
		}

		private string LatestVersion_Get()
		{
			int Int_Index = Release_Latest.TagName.IndexOf("v");
			return (Int_Index == -1) ? Release_Latest.TagName : Release_Latest.TagName.Substring(Int_Index);
		}

		public void Update_Run()
		{
			string String_StartupDirectory = Path.GetDirectoryName(System.Windows.Forms.Application.StartupPath);
			string String_OriginalProductName = System.Windows.Forms.Application.ProductName;

			String_LatestVersion = LatestVersion_Get();
			ZipFile.ExtractToDirectory($"{String_ProductName}_Latest.zip", String_StartupDirectory);

			Classes.Class_AdditionalMethods.Process_Start
				("CMD.exe", $"/C TaskKill /F /IM \"{String_OriginalProductName}.exe\" && TimeOut /T 1 && Del /S /F /Q *.* " +
				$"&& start CMD.exe /C Move /Y \"{String_StartupDirectory}\\{String_OriginalProductName} {String_LatestVersion}\\*.*\" . " +
				$"&& TimeOut /T 1 && RMDir /S /Q \"{String_StartupDirectory}\\{String_OriginalProductName} {String_LatestVersion}\" && \"{String_OriginalProductName}.exe\"");
		}
	}
}