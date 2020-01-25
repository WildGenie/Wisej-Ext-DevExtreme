using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxFunnel : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxFunnel()
		{
			InitializeComponent();

			this.dxFunnel1.Widget.itemClick += new WidgetEventHandler(dxFunnel1_WidgetEvent);
			this.dxFunnel1.Widget.legendClick += new WidgetEventHandler(dxFunnel1_WidgetEvent);
		}

		private void dxFunnel1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
