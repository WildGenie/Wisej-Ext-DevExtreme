using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxTreeMap : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxTreeMap()
		{
			InitializeComponent();

			this.dxTreeMap1.Widget.click += new WidgetEventHandler(dxTreeMap1_WidgetEvent);
		}

		private void dxTreeMap1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
