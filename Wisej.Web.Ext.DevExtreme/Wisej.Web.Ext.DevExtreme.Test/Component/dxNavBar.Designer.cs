namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxNavBar
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
            this.dxNavBar1 = new Wisej.Web.Ext.DevExtreme.dxNavBar();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/NavBar/Overview/";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxNavBar/";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.dxNavBar1);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/NavBar/Overview/jQuery/Light/" +
    "";
            // 
            // dxNavBar1
            // 
            this.dxNavBar1.Dock = Wisej.Web.DockStyle.Bottom;
            this.dxNavBar1.Location = new System.Drawing.Point(0, 249);
            this.dxNavBar1.Name = "dxNavBar1";
            this.dxNavBar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"selectedIndex\":0,\"dataSource\":[{\"text\":\"Contacts\",\"icon\":\"user\"},{\"text\":\"Misse" +
        "d\",\"icon\":\"clock\",\"badge\":3},{\"text\":\"Favorites\",\"icon\":\"favorites\"}]}")));
            this.dxNavBar1.Size = new System.Drawing.Size(453, 64);
            this.dxNavBar1.Text = "dxNavBar1";
            // 
            // dxNavBar
            // 
            this.Name = "dxNavBar";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxNavBar dxNavBar1;
	}
}
