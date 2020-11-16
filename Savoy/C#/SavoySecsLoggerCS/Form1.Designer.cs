namespace SavoySecsLoggerCS
{
	partial class Form1
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.portASettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.portBSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripTargetPort = new System.Windows.Forms.ToolStripComboBox();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.axSavoySecsI1 = new AxSAVOYLib.AxSavoySecsI();
			this.axSavoySecsII1 = new AxSAVOYLib.AxSavoySecsII();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.axSavoySecsI2 = new AxSAVOYLib.AxSavoySecsI();
			this.axSavoySecsII2 = new AxSAVOYLib.AxSavoySecsII();
			this.splitContainer5 = new System.Windows.Forms.SplitContainer();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsI1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsII1)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsI2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsII2)).BeginInit();
			this.splitContainer5.Panel1.SuspendLayout();
			this.splitContainer5.Panel2.SuspendLayout();
			this.splitContainer5.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(643, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "&View";
			// 
			// refreshToolStripMenuItem
			// 
			this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
			this.refreshToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.refreshToolStripMenuItem.Text = "&Refresh";
			this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.toolStripSeparator8,
            this.optionsToolStripMenuItem});
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.toolsToolStripMenuItem.Text = "&Communication";
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.connectToolStripMenuItem.Text = "Co&nnect";
			this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
			// 
			// disconnectToolStripMenuItem
			// 
			this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
			this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.disconnectToolStripMenuItem.Text = "&Disconnect";
			this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
			// 
			// toolStripSeparator8
			// 
			this.toolStripSeparator8.Name = "toolStripSeparator8";
			this.toolStripSeparator8.Size = new System.Drawing.Size(130, 6);
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.portASettingToolStripMenuItem,
            this.portBSettingToolStripMenuItem});
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.optionsToolStripMenuItem.Text = "&Options";
			// 
			// portASettingToolStripMenuItem
			// 
			this.portASettingToolStripMenuItem.Name = "portASettingToolStripMenuItem";
			this.portASettingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.portASettingToolStripMenuItem.Text = "Port# &A Setting...";
			this.portASettingToolStripMenuItem.Click += new System.EventHandler(this.portASettingToolStripMenuItem_Click);
			// 
			// portBSettingToolStripMenuItem
			// 
			this.portBSettingToolStripMenuItem.Name = "portBSettingToolStripMenuItem";
			this.portBSettingToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
			this.portBSettingToolStripMenuItem.Text = "Port# &B Setting...";
			this.portBSettingToolStripMenuItem.Click += new System.EventHandler(this.portBSettingToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
			this.aboutToolStripMenuItem.Text = "&About SavoySecsLogger...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTargetPort,
            this.toolStripSeparator7,
            this.helpToolStripButton});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(643, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripTargetPort
			// 
			this.toolStripTargetPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.toolStripTargetPort.Items.AddRange(new object[] {
            "Port# A",
            "Port# B"});
			this.toolStripTargetPort.Name = "toolStripTargetPort";
			this.toolStripTargetPort.Size = new System.Drawing.Size(75, 25);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// helpToolStripButton
			// 
			this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
			this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.helpToolStripButton.Name = "helpToolStripButton";
			this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
			this.helpToolStripButton.Text = "He&lp";
			this.helpToolStripButton.Click += new System.EventHandler(this.helpToolStripButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 430);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(643, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer5);
			this.splitContainer1.Size = new System.Drawing.Size(643, 381);
			this.splitContainer1.SplitterDistance = 213;
			this.splitContainer1.TabIndex = 3;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
			this.splitContainer2.Size = new System.Drawing.Size(213, 381);
			this.splitContainer2.SplitterDistance = 185;
			this.splitContainer2.TabIndex = 0;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.axSavoySecsI1);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.axSavoySecsII1);
			this.splitContainer3.Size = new System.Drawing.Size(213, 185);
			this.splitContainer3.SplitterDistance = 89;
			this.splitContainer3.TabIndex = 0;
			// 
			// axSavoySecsI1
			// 
			this.axSavoySecsI1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axSavoySecsI1.Enabled = true;
			this.axSavoySecsI1.Location = new System.Drawing.Point(0, 0);
			this.axSavoySecsI1.Name = "axSavoySecsI1";
			this.axSavoySecsI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSavoySecsI1.OcxState")));
			this.axSavoySecsI1.Size = new System.Drawing.Size(213, 89);
			this.axSavoySecsI1.TabIndex = 0;
			this.axSavoySecsI1.Sent += new AxSAVOYLib._DSavoySecsIEvents_SentEventHandler(this.axSavoySecsI1_Sent);
			this.axSavoySecsI1.Received += new AxSAVOYLib._DSavoySecsIEvents_ReceivedEventHandler(this.axSavoySecsI1_Received);
			// 
			// axSavoySecsII1
			// 
			this.axSavoySecsII1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axSavoySecsII1.Enabled = true;
			this.axSavoySecsII1.Location = new System.Drawing.Point(0, 0);
			this.axSavoySecsII1.Name = "axSavoySecsII1";
			this.axSavoySecsII1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSavoySecsII1.OcxState")));
			this.axSavoySecsII1.Size = new System.Drawing.Size(213, 92);
			this.axSavoySecsII1.TabIndex = 0;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.axSavoySecsI2);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.axSavoySecsII2);
			this.splitContainer4.Size = new System.Drawing.Size(213, 192);
			this.splitContainer4.SplitterDistance = 90;
			this.splitContainer4.TabIndex = 0;
			// 
			// axSavoySecsI2
			// 
			this.axSavoySecsI2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axSavoySecsI2.Enabled = true;
			this.axSavoySecsI2.Location = new System.Drawing.Point(0, 0);
			this.axSavoySecsI2.Name = "axSavoySecsI2";
			this.axSavoySecsI2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSavoySecsI2.OcxState")));
			this.axSavoySecsI2.Size = new System.Drawing.Size(213, 90);
			this.axSavoySecsI2.TabIndex = 0;
			this.axSavoySecsI2.Sent += new AxSAVOYLib._DSavoySecsIEvents_SentEventHandler(this.axSavoySecsI2_Sent);
			this.axSavoySecsI2.Received += new AxSAVOYLib._DSavoySecsIEvents_ReceivedEventHandler(this.axSavoySecsI2_Received);
			// 
			// axSavoySecsII2
			// 
			this.axSavoySecsII2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.axSavoySecsII2.Enabled = true;
			this.axSavoySecsII2.Location = new System.Drawing.Point(0, 0);
			this.axSavoySecsII2.Name = "axSavoySecsII2";
			this.axSavoySecsII2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axSavoySecsII2.OcxState")));
			this.axSavoySecsII2.Size = new System.Drawing.Size(213, 98);
			this.axSavoySecsII2.TabIndex = 0;
			// 
			// splitContainer5
			// 
			this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer5.Location = new System.Drawing.Point(0, 0);
			this.splitContainer5.Name = "splitContainer5";
			this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer5.Panel1
			// 
			this.splitContainer5.Panel1.Controls.Add(this.listBox1);
			// 
			// splitContainer5.Panel2
			// 
			this.splitContainer5.Panel2.Controls.Add(this.listBox2);
			this.splitContainer5.Size = new System.Drawing.Size(426, 381);
			this.splitContainer5.SplitterDistance = 116;
			this.splitContainer5.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.IntegralHeight = false;
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.MultiColumn = true;
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(426, 116);
			this.listBox1.TabIndex = 0;
			this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
			// 
			// listBox2
			// 
			this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Location = new System.Drawing.Point(0, 0);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(426, 251);
			this.listBox2.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(643, 452);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Savoy SECS Logger (Visual C#)";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			this.splitContainer3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsI1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsII1)).EndInit();
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			this.splitContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsI2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.axSavoySecsII2)).EndInit();
			this.splitContainer5.Panel1.ResumeLayout(false);
			this.splitContainer5.Panel2.ResumeLayout(false);
			this.splitContainer5.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton helpToolStripButton;
		private AxSAVOYLib.AxSavoySecsI axSavoySecsI1;
		private AxSAVOYLib.AxSavoySecsII axSavoySecsII1;
		private AxSAVOYLib.AxSavoySecsI axSavoySecsI2;
		private AxSAVOYLib.AxSavoySecsII axSavoySecsII2;
		private System.Windows.Forms.ToolStripMenuItem portASettingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem portBSettingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
		private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer5;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox toolStripTargetPort;
	}
}

