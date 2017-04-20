using System.Collections.Generic;
using System.IO;
using Android.Gms.Vision.Texts;

namespace MyStuff
{
	public interface IReceiptAnalyser
	{
		IEnumerable<ShoppingItem> Analyse(Stream source);
	}
}
