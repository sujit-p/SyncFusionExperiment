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
			// I don't want to be specifying the series in code-behind because I want the series to be in XAML, also at this point (in constructor) the bindings are not set
			// and this will cause problems for me.

			((SfChart)RangeNavigator.Content).Series.Clear();
			((SfChart)RangeNavigator.Content).Series.Add(new SplineAreaSeries() { ItemsSource = series.ItemsSource, XBindingPath = "XValue", YBindingPath = "YValue" });

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
