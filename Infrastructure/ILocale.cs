using System;
namespace Infrastructure
{
	/// <summary>
	/// Data related to language, etc.
	/// </summary>
	public interface ILocale
	{
		#region Shopping item edit

		string SIMissingItemTitle { get; }

		string SIMissingItemMessage { get; }

		string SIMissingItemConfirm { get; }

		string SINamePlaceHolder { get; }

		string SIAmountPlaceHolder { get; }

		string SIConfirmTitle { get; }

		string RUnknownErrorTitle { get;  }

		string RUnknonwnMessage { get; }

		string RUnknownErrorConfirm { get; }

		#endregion
	}
}
