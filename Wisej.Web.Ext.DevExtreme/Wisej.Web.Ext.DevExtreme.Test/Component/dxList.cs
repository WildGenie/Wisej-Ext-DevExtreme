using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxList : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxList()
		{
			InitializeComponent();

			this.dxList1.Widget.itemClick += new WidgetEventHandler(dxList1_WidgetEvent);
			this.dxList1.Widget.pullRefresh += new WidgetEventHandler(dxList1_WidgetEvent);
		}

		private void dxList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
