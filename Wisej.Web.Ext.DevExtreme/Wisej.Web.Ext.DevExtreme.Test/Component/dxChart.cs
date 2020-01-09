using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxChart : TestBase
	{
		public dxChart()
		{
			InitializeComponent();

			this.dxChart1.Widget.seriesClick += new WidgetEventHandler(dxChart1_WidgetEvent);
			this.dxChart1.Widget.legendClick += new WidgetEventHandler(dxChart1_WidgetEvent);
		}

		private void dxChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
