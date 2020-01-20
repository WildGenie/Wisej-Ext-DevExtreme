using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxFileManager : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxFileManager()
		{
			InitializeComponent();

			this.dxFileManager1.Widget.currentDirectoryChanged += new WidgetEventHandler(dxFileManager1_WidgetEvent);
		}

		private void dxFileManager1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}
	}
}
