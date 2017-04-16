using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MyStuff
{
	public interface IMainMdViewModel : INotifyPropertyChanged
	{
		ICommand NavigateShoppingItems {get; set;}

		ICommand NavigateReceipts {get; set;}
	}
}
