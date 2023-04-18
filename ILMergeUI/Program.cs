using System.Windows.Forms;
using System;

namespace ILMergeUI
{
	public static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Template());
		}
	}
}