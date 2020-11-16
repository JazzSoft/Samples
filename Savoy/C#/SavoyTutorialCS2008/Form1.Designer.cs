namespace SavoyTutorialCS2008
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
			this.hsms = new AxSAVOYLib.AxSavoyHsms();
			this.inmsg = new AxSAVOYLib.AxSavoySecsII();
			this.outmsg = new AxSAVOYLib.AxSavoySecsII();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.hsms)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.inmsg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.outmsg)).BeginInit();
			this.SuspendLayout();
			// 
			// hsms
			// 
			this.hsms.Enabled = true;
			this.hsms.Location = new System.Drawing.Point(12, 12);
			this.hsms.Name = "hsms";
			this.hsms.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("hsms.OcxState")));
			this.hsms.Size = new System.Drawing.Size(266, 70);
			this.hsms.TabIndex = 0;
			this.hsms.Received += new AxSAVOYLib._DSavoyHsmsEvents_ReceivedEventHandler(this.hsms_Received);
			this.hsms.Connected += new AxSAVOYLib._DSavoyHsmsEvents_ConnectedEventHandler(this.hsms_Connected);
			// 
			// inmsg
			// 
			this.inmsg.Enabled = true;
			this.inmsg.Location = new System.Drawing.Point(12, 88);
			this.inmsg.Name = "inmsg";
			this.inmsg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("inmsg.OcxState")));
			this.inmsg.Size = new System.Drawing.Size(178, 82);
			this.inmsg.TabIndex = 1;
			// 
			// outmsg
			// 
			this.outmsg.Enabled = true;
			this.outmsg.Location = new System.Drawing.Point(12, 176);
			this.outmsg.Name = "outmsg";
			this.outmsg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("outmsg.OcxState")));
			this.outmsg.Size = new System.Drawing.Size(178, 82);
			this.outmsg.TabIndex = 2;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(196, 88);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 30);
			this.button1.TabIndex = 3;
			this.button1.Text = "&Open...";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(196, 124);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(82, 30);
			this.button2.TabIndex = 4;
			this.button2.Text = "On&line";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(196, 160);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(82, 20);
			this.textBox1.TabIndex = 5;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(196, 186);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(82, 30);
			this.button3.TabIndex = 6;
			this.button3.Text = "&PP Select";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(196, 222);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(82, 30);
			this.button4.TabIndex = 7;
			this.button4.Text = "PP &Start";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 270);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.outmsg);
			this.Controls.Add(this.inmsg);
			this.Controls.Add(this.hsms);
			this.Name = "Form1";
			this.Text = "Savoy Tutorial C#2008";
			((System.ComponentModel.ISupportInitialize)(this.hsms)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.inmsg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.outmsg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxSAVOYLib.AxSavoyHsms hsms;
		private AxSAVOYLib.AxSavoySecsII inmsg;
		private AxSAVOYLib.AxSavoySecsII outmsg;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
	}
}

