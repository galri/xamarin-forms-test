using Prism.Mvvm;
using Prism.Unity;
using Microsoft.Practices.Unity;
using Xamarin.Forms;
using Infrastructure;
using Microsoft.Practices.ServiceLocation;
using System;
using XLabs.Platform.Services.Media;

namespace MyStuff
{
	public partial class App : PrismApplication
	{
		public App()
		{
			InitializeComponent();
		}

		protected override void OnInitialized()
		{
			NavigationService.NavigateAsync( "MD/Navigation/SL" );
		}

		protected override void RegisterTypes()
		{
			Container.RegisterType<ILocale, RessourceFileLocale>();
			XamlLocale.Locale = Container.Resolve<ILocale>();
			Container.RegisterType<IMediaPicker, MediaPicker>();

			Container.RegisterType<IShoppingItemsService, ShopingItemservice>();
			Container.RegisterType<IShoppingListView, ShoppingList>();
			Container.RegisterType<IShoppingListViewModel, ShoppingListViewModel>();

			Container.RegisterType<IShoppingItemView, ShoppingItemView>();
			Container.RegisterType<IShoppingItemViewModel, ShoppingItemViewModel>();

			Container.RegisterType<IMainMdView, MainMdView>();
			Container.RegisterType<IMainMdViewModel, MainMdViewModel>();

			Container.RegisterType<IReceiptAnalyseView,ReceiptAnalyseView>();
			Container.RegisterType<IReceiptAnalyseViewModel,ReceiptAnalyseViewModel>();

			Container.RegisterTypeForNavigation(Container.Resolve<IShoppingListView>().GetType(),"SL");
			Container.RegisterTypeForNavigation(Container.Resolve<IShoppingItemView>().GetType(),"SI");
			Container.RegisterTypeForNavigation(Container.Resolve<IMainMdView>().GetType(),"MD");
			Container.RegisterTypeForNavigation(Container.Resolve<IReceiptAnalyseView>().GetType(),"R");
			Container.RegisterTypeForNavigation<NavigationPage>( "Navigation" );
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
