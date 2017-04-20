using System;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.Content;
using Android.Gms.Vision;
using Android.Gms.Vision.Texts;
using Android.Graphics;
using MyStuff.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(ReceiptAnalyser))]
namespace MyStuff.Droid
{
	public class ReceiptAnalyser : IReceiptAnalyser
	{

		public IEnumerable<ShoppingItem> Analyse(Stream source)
		{
			var builder = new TextRecognizer.Builder(Forms.Context);
			var recognizer = builder.Build();
			var bitmap = BitmapFactory.DecodeStream(source);
			var frame = new Android.Gms.Vision.Frame.Builder().SetBitmap(bitmap).Build();
			var results = recognizer.Detect(frame);
			ShoppingItem[] toResturn = new ShoppingItem[results.Size()];
			for (int i = 0; i < results.Size(); i++)
			{
				var name = results.ValueAt(i) as TextBlock;
				toResturn[i] = new ShoppingItem() { Name = name.Value ?? ""};
			}

			return toResturn;
		}
	}
}
