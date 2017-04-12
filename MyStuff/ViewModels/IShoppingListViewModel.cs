using System;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace MyStuff
{
	public interface IShoppingListViewModel : INotifyPropertyChanged
	{
		ShoppingItem SelectedShoppingItem { get; set; }

		ObservableCollection<ShoppingItem> ShoppingItems { get; set; }
	}
}
