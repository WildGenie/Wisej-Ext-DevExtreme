namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxPolarChart
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dxPolarChart));
			this.dxPolarChart1 = new Wisej.Web.Ext.DevExtreme.dxPolarChart();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/PolarChart/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/Data_Visualization_Widgets/d" +
    "xPolarChart/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxPolarChart1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Charts/ContinuousData/jQuery/" +
    "Light/";
			// 
			// dxPolarChart1
			// 
			this.dxPolarChart1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxPolarChart1.Location = new System.Drawing.Point(19, 12);
			this.dxPolarChart1.Name = "dxPolarChart1";
			this.dxPolarChart1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("dxPolarChart1.Options"))));
			this.dxPolarChart1.Size = new System.Drawing.Size(415, 288);
			this.dxPolarChart1.TabIndex = 0;
			this.dxPolarChart1.Text = "dxPolarChart1";
			// 
			// dxPolarChart
			// 
			this.Name = "dxPolarChart";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxPolarChart dxPolarChart1;
	}
}
