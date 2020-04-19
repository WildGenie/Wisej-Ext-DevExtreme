using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxRangeSelector : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxRangeSelector()
		{
			InitializeComponent();

			this.dxRangeSelector1.Widget.valueChanged += new WidgetEventHandler(dxRangeSelector1_WidgetEvent);

			this.dxRangeSelector1.Options.scale = new { startValue = 15000, endValue = 150000, minorTickInterval = 500, tickInterval = 15000, label = new { format = "currency" } };
			this.dxRangeSelector1.Options.slideMarker = new { format = "currency" };
		}

		private void dxRangeSelector1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
