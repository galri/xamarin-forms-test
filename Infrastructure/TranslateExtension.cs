using System;
using Infrastructure;
using Microsoft.Practices.ServiceLocation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyStuff
{
	[ContentProperty("Text")]
	public class TranslateExtension : IMarkupExtension
	{
		public string Text
		{
			get;
			set;
		}

		public object ProvideValue(IServiceProvider serviceProvider)
		{
			var locale = (ILocale)ServiceLocator.Current.GetService(typeof(ILocale));
			switch (Text)
			{
				case "SINP":
					return locale.SINamePlaceHolder;
				case "SIAP":
					return locale.SIAmountPlaceHolder;
				case "SICT":
					return locale.SIConfirmTitle;
				default:
					return "";
			}
		}
	}
}
