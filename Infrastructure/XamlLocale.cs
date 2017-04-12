using System;
namespace Infrastructure
{
	/// <summary>
	/// Helper class for text locale in xaml.
	/// </summary>
	public static class XamlLocale 
	{
		public static ILocale Locale
		{
			get;
			set;
		}

		static XamlLocale()
		{
		}

		public static string test { get; set; } = "Test";
	}
}
