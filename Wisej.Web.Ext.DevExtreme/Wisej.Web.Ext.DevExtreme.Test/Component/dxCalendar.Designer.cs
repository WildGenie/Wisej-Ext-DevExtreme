namespace Wisej.Web.Ext.DevExtreme.Test.Component
{
	partial class dxCalendar
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
			this.dxCalendar1 = new Wisej.Web.Ext.DevExtreme.dxCalendar();
			this.comboBoxFirstDayOfWeek = new Wisej.Web.ComboBox();
			this.checkBoxShowTodayButton = new Wisej.Web.CheckBox();
			this.groupBox1.SuspendLayout();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// linkDocs
			// 
			this.linkDocs.Text = "https://js.devexpress.com/Documentation/Guide/Widgets/Calendar/Overview/";
			// 
			// linkAPI
			// 
			this.linkAPI.Text = "https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxCalendar/";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkBoxShowTodayButton);
			this.groupBox1.Controls.Add(this.comboBoxFirstDayOfWeek);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.comboBoxFirstDayOfWeek, 0);
			this.groupBox1.Controls.SetChildIndex(this.checkBoxShowTodayButton, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// panel
			// 
			this.panel.Controls.Add(this.dxCalendar1);
			// 
			// linkDemo
			// 
			this.linkDemo.Text = "https://js.devexpress.com/Demos/WidgetsGallery/Demo/Calendar/Overview/";
			// 
			// dxCalendar1
			// 
			this.dxCalendar1.Anchor = ((Wisej.Web.AnchorStyles)((((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Bottom) 
            | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
			this.dxCalendar1.Location = new System.Drawing.Point(27, 20);
			this.dxCalendar1.Name = "dxCalendar1";
			this.dxCalendar1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":\"2020-01-01\",\"disabled\":false,\"firstDayOfWeek\":0,\"zoomLevel\":\"month\"}")));
			this.dxCalendar1.Size = new System.Drawing.Size(399, 273);
			this.dxCalendar1.Text = "dxCalendar1";
			// 
			// comboBoxFirstDayOfWeek
			// 
			this.comboBoxFirstDayOfWeek.AutoSize = false;
			this.comboBoxFirstDayOfWeek.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
			this.comboBoxFirstDayOfWeek.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
			this.comboBoxFirstDayOfWeek.Label.Size = 50;
			this.comboBoxFirstDayOfWeek.Label.SizeType = Wisej.Web.SizeType.Percent;
			this.comboBoxFirstDayOfWeek.Label.Text = "First Day of Week";
			this.comboBoxFirstDayOfWeek.Location = new System.Drawing.Point(28, 39);
			this.comboBoxFirstDayOfWeek.Name = "comboBoxFirstDayOfWeek";
			this.comboBoxFirstDayOfWeek.ShowToolTips = false;
			this.comboBoxFirstDayOfWeek.Size = new System.Drawing.Size(195, 60);
			this.comboBoxFirstDayOfWeek.TabIndex = 3;
			this.comboBoxFirstDayOfWeek.Text = "Sunday";
			// 
			// checkBoxShowTodayButton
			// 
			this.checkBoxShowTodayButton.Appearance = Wisej.Web.Appearance.Switch;
			this.checkBoxShowTodayButton.AutoSize = false;
			this.checkBoxShowTodayButton.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxShowTodayButton.Location = new System.Drawing.Point(28, 135);
			this.checkBoxShowTodayButton.Name = "checkBoxShowTodayButton";
			this.checkBoxShowTodayButton.Size = new System.Drawing.Size(195, 38);
			this.checkBoxShowTodayButton.TabIndex = 7;
			this.checkBoxShowTodayButton.Text = "Show Today Button";
			// 
			// dxCalendar
			// 
			this.Name = "dxCalendar";
			this.groupBox1.ResumeLayout(false);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExtreme.dxCalendar dxCalendar1;
        private ComboBox comboBoxFirstDayOfWeek;
		private CheckBox checkBoxShowTodayButton;
	}
}
