using System.Diagnostics;
using System.Net;

namespace ILMergeUI.ResourcesData.Source.Core
{
	public class AdditionalMethods
	{
		public bool Connection_Check(string String_HostName)
		{
			try
			{
				Dns.GetHostEntry(String_HostName);
				return true;
			}

			catch { return false; }
		}

		public string Symbols_Remove(string String_Text)
		{
			string String_Digit = string.Empty;

			foreach (char Char_Letter in String_Text)
			{
				if (char.IsDigit(Char_Letter))
				{ String_Digit += Char_Letter; }
			}

			return String_Digit;
		}

		public string Process_Start(string String_Name, string String_Arguments)
		{
			Process Process_Some = new Process();

			Process_Some.StartInfo.FileName = String_Name;
			Process_Some.StartInfo.Arguments = String_Arguments;
			Process_Some.StartInfo.RedirectStandardOutput = true;
			Process_Some.StartInfo.UseShellExecute = false;
			Process_Some.StartInfo.CreateNoWindow = true;

			Process_Some.Start();
			Process_Some.WaitForExit();

			return Process_Some.StandardOutput.ReadToEnd();
		}
	}
}