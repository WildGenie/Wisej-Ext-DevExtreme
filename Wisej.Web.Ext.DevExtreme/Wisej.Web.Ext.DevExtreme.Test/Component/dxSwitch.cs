using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxSwitch : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxSwitch()
		{
			InitializeComponent();

			this.dxSwitch1.Checked = true;
		}

		private void dxSwitch1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
