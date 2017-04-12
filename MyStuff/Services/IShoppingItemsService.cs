using System.Collections.Generic;

namespace MyStuff
{
	public interface IShoppingItemsService
	{
		IEnumerable<ShoppingItem> GetItems();
	}
}
