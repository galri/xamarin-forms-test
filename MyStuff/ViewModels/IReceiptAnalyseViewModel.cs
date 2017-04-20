using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MyStuff
{
	public interface IReceiptAnalyseViewModel
	{
		ICommand AnalyseImageCommand { get; set; }

		ObservableCollection<ShoppingItem> ShoppingItems { get; set; }
	}
}
