using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxTreeList : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxTreeList()
		{
			InitializeComponent();

			this.dxTreeList1.Widget.cellClick += new WidgetEventHandler(dxTreeList1_WidgetEvent);
		}

		private void dxTreeList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
