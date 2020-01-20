using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxDiagram : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxDiagram()
		{
			InitializeComponent();

			this.dxDiagram1.Widget.itemClick += new WidgetEventHandler(dxDiagram1_WidgetEvent);
		}

		private void dxDiagram1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
