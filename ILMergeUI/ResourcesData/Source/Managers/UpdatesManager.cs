using ILMergeUI.ResourcesData.Source.Root;
using System.Threading.Tasks;

namespace ILMergeUI.ResourcesData.Source.Managers
{
	public class UpdatesManager
	{
		public Task<int> Status_Get()
		{ return Classes.Class_UpdatesController.Status_Get(); }

		public string Body_Get()
		{ return Classes.Class_UpdatesController.Release_Latest.Body; }

		public async Task Update_DownloadAndRun()
		{ await Classes.Class_UpdatesController.Update_Download(); }
	}
}