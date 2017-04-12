using System;
using Infrastructure;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Infrastructure
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
			ILocale locale;
			if (!ServiceLocator.IsLocationProviderSet)
			{
				//TODO: most likely design time, need And check
				locale = new RessourceFileLocale();
			}
			else
			{
				locale = (ILocale)ServiceLocator.Current.GetService(typeof(ILocale));
			}
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
