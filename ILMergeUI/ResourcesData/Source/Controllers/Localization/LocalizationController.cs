using ILMergeUI.Properties;
using System.Collections.Generic;
using System.Xml;

namespace ILMergeUI.ResourcesData.Source.Controllers.Localization
{
	public class LocalizationController
	{
		public readonly Dictionary<string, string[]> Dictionary_Localization = new Dictionary<string, string[]>();


		public void Localization_Load()
		{
			XmlDocument XmlDocument_Localization = new XmlDocument();
			XmlDocument_Localization.LoadXml(Resources.Localization);

			XmlNodeList XmlNodeList_Key = XmlDocument_Localization.GetElementsByTagName("Key");
			XmlNodeList XmlNodeList_English = XmlDocument_Localization.GetElementsByTagName("English");
			XmlNodeList XmlNodeList_Russian = XmlDocument_Localization.GetElementsByTagName("Russian");

			for (int Int_Key = 0; Int_Key < XmlNodeList_Key.Count; Int_Key++)
			{
				string[] Strings_Localization = { XmlNodeList_English[Int_Key].InnerText, XmlNodeList_Russian[Int_Key].InnerText };
				Dictionary_Localization.Add(XmlNodeList_Key[Int_Key].Attributes[0].Value, Strings_Localization);
			}
		}
	}
}