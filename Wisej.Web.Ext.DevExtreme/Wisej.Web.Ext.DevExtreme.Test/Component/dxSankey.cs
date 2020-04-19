using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxSankey : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxSankey()
		{
			InitializeComponent();

			this.dxSankey1.Widget.linkClick += new WidgetEventHandler(dxSankey1_WidgetEvent);
			this.dxSankey1.Widget.nodeClick += new WidgetEventHandler(dxSankey1_WidgetEvent);
		}

		private void dxSankey1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
