using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MyStuff
{
	public class SIDT : IShoppingItemViewModel
	{
		public SIDT()
		{
			ShoppingItem = new ShoppingItem()
			{
				Name = "Shopping item name",
				Amount = "10",
			};
		}

		public ICommand EditCommand { get; set; }

		public ShoppingItem ShoppingItem { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
