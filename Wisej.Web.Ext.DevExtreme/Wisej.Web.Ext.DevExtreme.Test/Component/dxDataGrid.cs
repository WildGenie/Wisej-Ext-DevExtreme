using System;
using System.IO;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	public partial class dxDataGrid : Wisej.Web.Ext.DevExtreme.Test.Component.TestBase
	{
		public dxDataGrid()
		{
			InitializeComponent();

			this.dxDataGrid1.Options.dataSource = Wisej.Core.WisejSerializer.Parse(File.ReadAllText(Application.MapPath("Data/DataGrid/data.json")));

			this.dxDataGrid1.Widget.cellClick += new WidgetEventHandler(dxDataGrid1_WidgetEvent);
		}

		private void dxDataGrid1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{


			this.dxDataGrid1.Options.allowColumnResizing = this.checkBoxAllowColumnResizing.Checked;
			this.dxDataGrid1.Options.allowColumnReordering = this.checkBoxAllowColumnReordering.Checked;
		}
	}
}
