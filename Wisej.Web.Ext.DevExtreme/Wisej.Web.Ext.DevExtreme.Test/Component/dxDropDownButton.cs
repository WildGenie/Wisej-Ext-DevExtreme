using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxDropDownButton : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxDropDownButton()
		{
			InitializeComponent();

			this.dxDropDownButton1.Text = "dxDropDownButton1";

			this.dxDropDownButton1.Widget.buttonClick += new WidgetEventHandler(dxDropDownButton1_WidgetEvent);
		}

		private void dxDropDownButton1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
