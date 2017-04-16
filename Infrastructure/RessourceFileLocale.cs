using System;
namespace Infrastructure
{
	public class RessourceFileLocale : ILocale
	{
		public RessourceFileLocale()
		{
		}

		public string RUnknonwnMessage
		{
			get
			{
				return AppResources.ReceiptUnknonwnErrorMessage;
			}
		}

		public string RUnknownErrorTitle
		{
			get
			{
				return AppResources.ReceiptUnknonwnErrorTitle;
			}
		}

		public string SIAmountPlaceHolder
		{
			get
			{
				return AppResources.ShoppingListItemAmountPlaceholder;
			}
		}

		public string SIConfirmTitle
		{
			get
			{
				return AppResources.ShoppingListItemConfirmTitle;
			}
		}

		public string SIMissingItemConfirm
		{
			get
			{
				return Infrastructure.AppResources.ShoppingListItemMissingConfirm;
			}
		}

		public string SIMissingItemMessage
		{
			get
			{
				return Infrastructure.AppResources.ShoppingListItemMissingMessage;
			}
		}

		public string SIMissingItemTitle
		{
			get
			{
				return Infrastructure.AppResources.ShoppingListItemMissingTitle;
			}
		}

		public string SINamePlaceHolder
		{
			get
			{
				return Infrastructure.AppResources.ShoppingListItemNamePlaceholder;
			}
		}

		public string RUnknownErrorConfirm
		{
			get
			{
				return AppResources.ReceiptUnknonwnErrorConfirm;
			}
		}
	}
}
