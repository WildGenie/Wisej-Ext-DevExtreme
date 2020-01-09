namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxDataGrid
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxDataGrid));
            this.dxDataGrid1 = new Wisej.Web.Ext.DevExtreme.dxDataGrid();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/DataGrid/Overview/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxDataGrid1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/DataGrid/SimpleArray/jQuery/L" +
    "ight/";
            // 
            // dxDataGrid1
            // 
            this.dxDataGrid1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.dxDataGrid1.Location = new System.Drawing.Point(23, 18);
            this.dxDataGrid1.Name = "dxDataGrid1";
            this.dxDataGrid1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxDataGrid1.Options"))));
            this.dxDataGrid1.Size = new System.Drawing.Size(406, 276);
            this.dxDataGrid1.Text = "dxDataGrid1";
            // 
            // dxDataGrid
            // 
            this.Name = "dxDataGrid";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxDataGrid dxDataGrid1;
	}
}
