using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxProgressBar : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxProgressBar()
		{
			InitializeComponent();

			this.dxProgressBar1.Value = 40;
		}

		private void dxProgressBar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
