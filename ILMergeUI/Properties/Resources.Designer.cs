namespace ILMergeUI.Properties
{
	[global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
	[global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]


	internal class Resources
	{
		private static global::System.Resources.ResourceManager ResourceManager_ILMergeUI;
		private static global::System.Globalization.CultureInfo CultureInfo_ILMergeUI;


		[global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
		internal Resources() { }

		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Resources.ResourceManager ResourceManager_Cache
		{
			get
			{
				if (object.ReferenceEquals(ResourceManager_ILMergeUI, null))
				{
					global::System.Resources.ResourceManager ResourceManager_Temp = new global::System.Resources.ResourceManager("ILMergeUI.Properties.Resources", typeof(Resources).Assembly);
					ResourceManager_ILMergeUI = ResourceManager_Temp;
				}

				return ResourceManager_ILMergeUI;
			}
		}

		[global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
		internal static global::System.Globalization.CultureInfo CultureInfo_Rewrite
		{
			get { return CultureInfo_ILMergeUI; }
			set { CultureInfo_ILMergeUI = value; }
		}

		internal static System.Drawing.Bitmap Merge_Colored
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Merge_Colored", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Settings_Colored
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Settings_Colored", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Merge_White
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Merge_White", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap Settings_White
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("Settings_White", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static System.Drawing.Bitmap LanguageSwitcher
		{
			get
			{
				object Object_Bitmap = ResourceManager_Cache.GetObject("LanguageSwitcher", CultureInfo_Rewrite);
				return ((System.Drawing.Bitmap)(Object_Bitmap));
			}
		}

		internal static byte[] ILMerge
		{
			get
			{
				object Object_Bytes = ResourceManager_Cache.GetObject("ILMerge", CultureInfo_Rewrite);
				return ((byte[])(Object_Bytes));
			}
		}

		internal static byte[] System_Compiler
		{
			get
			{
				object Object_Bytes = ResourceManager_Cache.GetObject("System_Compiler", CultureInfo_Rewrite);
				return ((byte[])(Object_Bytes));
			}
		}

		internal static string Localization
		{
			get { return ResourceManager_Cache.GetString("Localization", CultureInfo_Rewrite); }
		}
	}
}