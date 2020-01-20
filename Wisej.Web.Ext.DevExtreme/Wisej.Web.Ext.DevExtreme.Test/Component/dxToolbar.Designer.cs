namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxToolbar
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
            this.dxToolbar1 = new Wisej.Web.Ext.DevExtreme.dxToolbar();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Toolbar/Overview/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxToolbar/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxToolbar1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Toolbar/Overview/jQuery/Light" +
    "/";
            // 
            // dxToolbar1
            // 
            this.dxToolbar1.Dock = Wisej.Web.DockStyle.Top;
            this.dxToolbar1.Name = "dxToolbar1";
            this.dxToolbar1.Size = new System.Drawing.Size(453, 28);
            this.dxToolbar1.Text = "dxToolbar1";
            // 
            // dxToolbar
            // 
            this.Name = "dxToolbar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxToolbar dxToolbar1;
	}
}
