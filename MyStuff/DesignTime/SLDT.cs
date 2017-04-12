using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using PocoGenerator;

namespace MyStuff
{
	public class SLDT : IShoppingListViewModel
	{
		public SLDT()
		{
			var gen = new Generator<ShoppingItem>();
			gen.Bt<ShoppingItem>().Possible(nameof(ShoppingItem.Name), new string[]
			{
				"asd",
				"test",
				"number3",
			});
			gen.Bt<ShoppingItem>().Possible(nameof(ShoppingItem.Amount), new string[]
			{
				"1",
				"3",
				"5",
			});
			ShoppingItems = new ObservableCollection<ShoppingItem>(gen.Generate(10));
			SelectedShoppingItem = ShoppingItems[1];
		}

		public ShoppingItem SelectedShoppingItem { get; set; } 

		public ObservableCollection<ShoppingItem> ShoppingItems { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
