using System;
using System.Collections.Generic;
using Syncfusion.SfChart.XForms;
using Xamarin.Forms;

namespace SyncFusionExperiment.Pages
{
	public partial class MetricsPage : ContentPage
	{
		public MetricsPage()
		{
			InitializeComponent();

			if (Device.OS == TargetPlatform.Android)
			{
				RangeNavigator.HeightRequest = 150;
			}
			else if (Device.OS == TargetPlatform.iOS)
			{
				RangeNavigator.HeightRequest = 100;
			}
		}
		void nac_RangeChanged(object sender, Syncfusion.RangeNavigator.XForms.RangeChangedEventArgs e)
		{
			dateTimeAxis.Minimum = e.ViewRangeStartDate;
			dateTimeAxis.Maximum = e.ViewRangeEndDate;
		}
	}
}
