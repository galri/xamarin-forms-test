﻿using System;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Mvvm;
using Prism.Navigation;

namespace MyStuff
{
	public class ShoppingListViewModel : BindableBase, IShoppingListViewModel, INavigationAware
	{
		public ObservableCollection<ShoppingItem> ShoppingItems
		{
			get;
			set;
		}
		ShoppingItem selectedShoppingItem;

		public ShoppingItem SelectedShoppingItem
		{
			get
			{
				return selectedShoppingItem;
			}

			set
			{
				if(SetProperty(ref selectedShoppingItem, value) && value != null)
				{
					NavigateToItem();
				}
			}
		}

		void NavigateToItem()
		{
			var param = new NavigationParameters();
			param.Add("item", SelectedShoppingItem.Key);
			navigationService.NavigateAsync("SI",param);
		}
		readonly INavigationService navigationService;

		public ShoppingListViewModel(IShoppingItemsService service, INavigationService navigationService)
		{
			this.navigationService = navigationService;
			ShoppingItems = new ObservableCollection<ShoppingItem>(service.GetItems());
		}

		public void OnNavigatedFrom(NavigationParameters parameters)
		{
			
		}

		public void OnNavigatedTo(NavigationParameters parameters)
		{
			//No selected item in list on startup
			SelectedShoppingItem = null;
		}

		public void OnNavigatingTo(NavigationParameters parameters)
		{
			//not invoked on backbutton android.
		}
	}
}
