using System;
using System.ComponentModel;

namespace MyStuff
{
	public class DTBase : INotifyPropertyChanged
	{
		public DTBase()
		{
		}

#pragma warning disable CS0067
		public event PropertyChangedEventHandler PropertyChanged;
#pragma warning restore CS0067
	}
}
