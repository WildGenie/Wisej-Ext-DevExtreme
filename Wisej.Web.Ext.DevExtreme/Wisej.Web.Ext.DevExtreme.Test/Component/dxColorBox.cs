using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxColorBox : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxColorBox()
		{
			InitializeComponent();

			this.dxColorBox1.Widget.valueChanged += new WidgetEventHandler(dxColorBox1_WidgetEvent);
		}

		private void dxColorBox1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
