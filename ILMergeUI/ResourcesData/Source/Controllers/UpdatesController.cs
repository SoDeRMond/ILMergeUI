using ILMergeUI.ResourcesData.Source.Root;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using Octokit;

namespace ILMergeUI.ResourcesData.Source.Controllers
{
	public class UpdatesController
	{
		private readonly string String_CurrentVersion = Classes.Class_AdditionalMethods.Symbols_Remove(System.Windows.Forms.Application.ProductVersion);

		private readonly string String_ExecutablePath = System.Windows.Forms.Application.ExecutablePath;
		private readonly string String_CompanyName = System.Windows.Forms.Application.CompanyName;
		private readonly string String_ProductName = System.Windows.Forms.Application.ProductName.Replace(" ", string.Empty);


		private GitHubClient GitHubClient_Update;
		public Release Release_Latest;


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
			{ WebClient_Update.DownloadFile(ReleaseAsset_Latest.BrowserDownloadUrl, $"{String_ProductName}_Latest.exe"); }
		}

		public void Update_Run()
		{
			Classes.Class_AdditionalMethods.Process_Start
				("CMD.exe", $"/C TaskKill /F /IM \"{String_ProductName}.exe\" && TimeOut /T 1 " +
				$"&& Del \"{String_ExecutablePath}\" && Ren {String_ProductName}_Latest.exe \"{String_ProductName}.exe\" && \"{String_ExecutablePath}\"");
		}
	}
}