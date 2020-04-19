using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxPolarChart : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxPolarChart()
		{
			InitializeComponent();

			this.dxPolarChart1.Widget.pointClick += new WidgetEventHandler(dxPolarChart1_WidgetEvent);
			this.dxPolarChart1.Widget.seriesSelectionChanged += new WidgetEventHandler(dxPolarChart1_WidgetEvent);
		}

		private void dxPolarChart1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
