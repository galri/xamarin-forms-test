using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Prism.Services;

namespace MyStuff
{
	public class MainMdViewModel : BindableBase, IMainMdViewModel
	{
		public ICommand NavigateReceipts { get; set; }

		public ICommand NavigateShoppingItems { get; set; }

		public INavigationService NavigationService { get; set; }

		public MainMdViewModel(INavigationService navigationService)
		{
			NavigationService = navigationService;
			NavigateShoppingItems = new DelegateCommand(NavigateSL);
			NavigateReceipts = new DelegateCommand(NavigateReceiptsAction);
		}

		async void NavigateSL()
		{
			await NavigationService.NavigateAsync("Navigation/SL");
		}

		async void NavigateReceiptsAction()
		{
			await NavigationService.NavigateAsync("Navigation/R");
		}
	}
}
