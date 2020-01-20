using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxDateBox : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxDateBox()
		{
			InitializeComponent();

			this.dxDateBox1.Widget.valueChanged += new WidgetEventHandler(dxDateBox1_WidgetEvent);
		}

		private void dxDateBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
