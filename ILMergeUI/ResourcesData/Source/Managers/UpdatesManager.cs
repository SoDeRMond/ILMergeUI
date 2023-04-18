using ILMergeUI.ResourcesData.Source.Core;
using System.Threading.Tasks;

namespace ILMergeUI.ResourcesData.Source.Managers
{
	public class UpdatesManager
	{
		public Task<int> Status_Get()
		{ return Classes.Class_UpdatesController.Status_Get(); }

		public string Body_Get()
		{ return Classes.Class_UpdatesController.Release_Latest.Body; }

		public async Task Update_Download()
		{ await Classes.Class_UpdatesController.Update_Download(); }

		public void Update_Run()
		{ Classes.Class_UpdatesController.Update_Run(); }
	}
}