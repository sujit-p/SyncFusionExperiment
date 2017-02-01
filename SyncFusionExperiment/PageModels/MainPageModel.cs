using System;
using FreshMvvm;
using PropertyChanged;
using Xamarin.Forms;

namespace SyncFusionExperiment.PageModels
{
	[ImplementPropertyChanged]
	public class MainPageModel : FreshBasePageModel
	{
		public MainPageModel()
		{
		}
		public Command GoToMetricsPageCommand
		{
			get
			{
				return new Command(async () => { await CoreMethods.PushPageModel<MetricsPageModel>(); });
			}
		}
	}
}
