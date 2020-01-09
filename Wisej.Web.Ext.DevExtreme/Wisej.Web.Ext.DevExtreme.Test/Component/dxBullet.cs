using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxBullet : TestBase
	{
		public dxBullet()
		{
			InitializeComponent();

			this.dxBullet1.Widget.optionChanged += new WidgetEventHandler(dxBullet1_WidgetEvent);
		}

		private void dxBullet1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
