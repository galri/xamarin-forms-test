using System;
using System.Windows.Input;

namespace MyStuff
{
	public interface IReceiptAnalyseViewModel
	{
		ICommand AnalyseImageCommand { get; set; }
	}
}
