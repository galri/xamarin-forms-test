using System;
using System.Collections.Generic;
using PocoGenerator;

namespace MyStuff
{
	public class ShopingItemservice : IShoppingItemsService
	{
		public ShopingItemservice()
		{
		}

		public ShoppingItem GetItem(int key)
		{
			return new ShoppingItem() { Key = key,Name = "A name", Amount = "1"};
		}

		public IEnumerable<ShoppingItem> GetItems()
		{
			var gen = new Generator<ShoppingItem>();
			gen.Bt<ShoppingItem>().Fixed("Name", "Name");
			gen.Bt<ShoppingItem>().Fixed("Amount", "4");
			return gen.Generate(10);
		}
	}
}
