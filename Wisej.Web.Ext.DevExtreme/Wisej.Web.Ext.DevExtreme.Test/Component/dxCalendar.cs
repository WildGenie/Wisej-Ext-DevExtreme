using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxCalendar : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxCalendar()
		{
			InitializeComponent();

			this.dxCalendar1.Widget.valueChanged += new WidgetEventHandler(dxCalendar1_WidgetEvent);
		}

		private void dxCalendar1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
