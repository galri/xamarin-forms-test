using System;
using System.Windows.Input;
using Infrastructure;
using Prism.Commands;
using Prism.Logging;
using Prism.Mvvm;
using Prism.Services;
using XLabs.Platform.Services.Media;

namespace MyStuff
{
	public class ReceiptAnalyseViewModel : BindableBase, IReceiptAnalyseViewModel
	{
		public ICommand AnalyseImageCommand { get; set; }

		readonly IMediaPicker mediaPicker;
		readonly IPageDialogService pageDialogService;
		readonly ILocale locale;
		readonly ILoggerFacade logger;

		public ReceiptAnalyseViewModel(IMediaPicker mediaPicker, 
		                             IPageDialogService pageDialogService,
		                             ILocale locale, ILoggerFacade logger)
		{
			this.logger = logger;
			this.locale = locale;
			this.pageDialogService = pageDialogService;
			this.mediaPicker = mediaPicker;
			AnalyseImageCommand = new DelegateCommand(AnalyzeAction);
		}

		async void AnalyzeAction()
		{

			try
			{
				//TODO:check if camera etc os available media.phot etc.

				var options = new CameraMediaStorageOptions()
				{
					SaveMediaOnCapture = false,
				};
				var result = await mediaPicker.TakePhotoAsync(options);
			}
			catch (Exception ex)
			{
				logger.Log(ex.Message + ex.StackTrace, Category.Exception, Priority.Medium);
				await pageDialogService.DisplayAlertAsync(locale.RUnknownErrorTitle, locale.RUnknonwnMessage, locale.RUnknownErrorConfirm);
			}

		}
	}
}
