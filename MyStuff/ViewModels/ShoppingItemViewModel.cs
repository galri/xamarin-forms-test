using System;
using System.Windows.Input;
using Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace MyStuff
{
	public class ShoppingItemViewModel : BindableBase, IShoppingItemViewModel, INavigationAware
	{
		public ICommand EditCommand { get; set; }
		ShoppingItem shoppingItem;

		public ShoppingItem ShoppingItem
		{
			get
			{
				return shoppingItem;
			}

			set
			{
				SetProperty(ref shoppingItem, value);
			}
		}

		readonly INavigationService navigationService;
		readonly IShoppingItemsService service;
		readonly IPageDialogService pageDialogService;
		readonly ILocale locale;

		public ShoppingItemViewModel(INavigationService navigationService, 
		                             IShoppingItemsService service, 
		                             IPageDialogService pageDialogService,
		                             ILocale locale)
		{
			this.locale = locale;
			this.pageDialogService = pageDialogService;
			this.service = service;
			this.navigationService = navigationService;
			EditCommand = new DelegateCommand(EditAction);
		}

		void EditAction()
		{
			
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			if (!parameters.ContainsKey("item"))
			{
				pageDialogService.DisplayAlertAsync(locale.SIMissingItemTitle, locale.SIMissingItemMessage, locale.SIMissingItemConfirm);
				navigationService.GoBackAsync();
			}
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			
		}
	}
}
