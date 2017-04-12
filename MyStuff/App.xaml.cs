using Prism.Mvvm;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Xamarin.Forms;
using Infrastructure;
using Microsoft.Practices.ServiceLocation;
using System;

namespace MyStuff
{
	public partial class App : PrismApplication
	{
		protected override void OnInitialized()
		{
			NavigationService.NavigateAsync("SL");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterType<ILocale, RessourceFileLocale>();
			XamlLocale.Locale = Container.Resolve<ILocale>();

			Container.RegisterType<IShoppingItemsService, ShopingItemservice>();
			Container.RegisterType<IShoppingListView, ShoppingList>();
			Container.RegisterType<IShoppingListViewModel, ShoppingListViewModel>();

			Container.RegisterType<IShoppingItemView, ShoppingItemView>();
			Container.RegisterType<IShoppingItemViewModel, ShoppingItemViewModel>();

			Container.RegisterTypeForNavigation(Container.Resolve<IShoppingListView>().GetType(),"SL");
			Container.RegisterTypeForNavigation(Container.Resolve<IShoppingItemView>().GetType(),"SI");
		}

		protected override void ConfigureContainer()
		{
			base.ConfigureContainer();

			ServiceLocator.SetLocatorProvider(HandleServiceLocatorProvider);
		}

		IServiceLocator HandleServiceLocatorProvider()
		{
			return new UnityServiceLocator(Container);
		}
	}
}
