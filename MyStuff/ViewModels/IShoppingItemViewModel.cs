using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MyStuff
{
	public interface IShoppingItemViewModel : INotifyPropertyChanged
	{
		ShoppingItem ShoppingItem
		{
			get;
			set;
		}

		ICommand EditCommand { get; set; }
	}
}
