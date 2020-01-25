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
			Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction();
			this.dxDataGrid1 = new Wisej.Web.Ext.DevExtreme.dxDataGrid();
			this.checkBoxAllowColumnResizing = new Wisej.Web.CheckBox();
			this.checkBoxAllowColumnReordering = new Wisej.Web.CheckBox();
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
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxAllowColumnReordering);
			this.groupBox1.Controls.Add(this.checkBoxAllowColumnResizing);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowColumnResizing, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxAllowColumnReordering, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
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
			widgetFunction1.Name = "discountCellTemplate";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			this.dxDataGrid1.WidgetFunctions = new Wisej.Web.Ext.DevExtreme.dxBase.WidgetFunction[] {
        widgetFunction1};
			// 
			// checkBox1
			// 
			this.checkBoxAllowColumnResizing.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowColumnResizing.AutoSize = false;
			this.checkBoxAllowColumnResizing.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowColumnResizing.Location = new System.Drawing.Point(28, 123);
			this.checkBoxAllowColumnResizing.Name = "checkBox1";
			this.checkBoxAllowColumnResizing.Size = new System.Drawing.Size(195, 38);
			this.checkBoxAllowColumnResizing.TabIndex = 11;
			this.checkBoxAllowColumnResizing.Text = "Allow Column Resizing";
			// 
			// checkBoxAllowColumnReordering
			// 
			this.checkBoxAllowColumnReordering.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxAllowColumnReordering.AutoSize = false;
			this.checkBoxAllowColumnReordering.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxAllowColumnReordering.Location = new System.Drawing.Point(28, 39);
			this.checkBoxAllowColumnReordering.Name = "checkBoxAllowColumnReordering";
			this.checkBoxAllowColumnReordering.Size = new System.Drawing.Size(195, 38);
			this.checkBoxAllowColumnReordering.TabIndex = 12;
			this.checkBoxAllowColumnReordering.Text = "Allow Column Reordering";
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
		private CheckBox checkBoxAllowColumnReordering;
		private CheckBox checkBoxAllowColumnResizing;
	}
}
