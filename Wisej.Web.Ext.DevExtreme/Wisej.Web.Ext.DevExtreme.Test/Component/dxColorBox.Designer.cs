namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxColorBox
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
			this.dxColorBox1 = new Wisej.Web.Ext.DevExtreme.dxColorBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/ColorBox/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxColorBox/";
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxColorBox1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/ColorBox/Overview/";
			// 
			// dxColorBox1
			// 
			this.dxColorBox1.Anchor = ((Wisej.Web.AnchorStyles)((Wisej.Web.AnchorStyles.Left | Wisej.Web.AnchorStyles.Right)));
			this.dxColorBox1.Location = new System.Drawing.Point(126, 141);
			this.dxColorBox1.Name = "dxColorBox1";
			this.dxColorBox1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"#f05b41\",\"editAlphaChannel\":true}")));
			this.dxColorBox1.Size = new System.Drawing.Size(200, 30);
			this.dxColorBox1.Text = "dxColorBox1";
			// 
			// dxColorBox
			// 
			this.Name = "dxColorBox";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxColorBox dxColorBox1;
	}
}
