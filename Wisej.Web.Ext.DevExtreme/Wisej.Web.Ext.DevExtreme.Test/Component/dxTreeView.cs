using System;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxTreeView : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxTreeView()
		{
			InitializeComponent();

			this.dxTreeView1.Widget.itemClick += new WidgetEventHandler(dxTreeView1_WidgetEvent);
			this.dxTreeView1.Widget.selectionChanged += new WidgetEventHandler(dxTreeView1_WidgetEvent);
		}

		private void dxTreeView1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
