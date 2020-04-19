using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxScheduler : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxScheduler()
		{
			InitializeComponent();

			this.dxScheduler1.Widget.appointmentClick += new WidgetEventHandler(dxScheduler1_WidgetEvent);
			this.dxScheduler1.Widget.appointmentAdded += new WidgetEventHandler(dxScheduler1_WidgetEvent);
			this.dxScheduler1.Widget.appointmentDeleted += new WidgetEventHandler(dxScheduler1_WidgetEvent);
		}

		private void dxScheduler1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
