using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SavoyHsmsLoggerCS
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// Change font
			listBox2.Font = new Font("Courier New", 9);

			Trace("====================================\n" +
			" Savoy HSMS Logger (C#)\n" +
			" 1.0.0.0\n" +
			"     on Sep,5th,2009\n" +
			" \n" +
			" Copyright(C)2009 Jazz Soft, Inc.\n" +
			"====================================");

			// Load settings
			axSavoyHsms1.LoadIniFile();
			axSavoyHsms2.LoadIniFile();

			// Connect
			connectToolStripMenuItem_Click(sender, e);

			// Enumerate message files
			refreshToolStripMenuItem_Click(sender, e);

			toolStripTargetPort.SelectedIndex = 0;
		}

		protected void Send(bool bPortA)
		{
			AxSAVOYLib.AxSavoyHsms secs = bPortA ? axSavoyHsms1 : axSavoyHsms2;
			AxSAVOYLib.AxSavoySecsII msg = bPortA ? axSavoySecsII1 : axSavoySecsII2;

			// Mend for SECS-I
			msg.BlockNumber = 1;

			Trace("Attempting to send to port# " + (bPortA ? "A" : "B") + "...");
			Trace(msg.SML);

			secs.Send(msg.Msg);
		}

		protected void Trace(string strText)
		{
			string strTemp = "";
			for (int nCnt = 0; nCnt < strText.Length; nCnt++)
			{
				switch (strText[nCnt])
				{
				case '\r':
					break;
				case '\n':
					listBox2.Items.Add(strTemp);
					strTemp = "";
					break;
				default:
					strTemp += strText[nCnt];
					break;
				}
			}

			if (strTemp != "")
				listBox2.Items.Add(strTemp);

			// Select last line
			int nCount = listBox2.Items.Count;
			if (nCount > 0)
				listBox2.SetSelected(nCount - 1, true);

			// Remove oldest ones if number of lines exceeds 5000
			while (listBox2.Items.Count > 5000)
				listBox2.Items.RemoveAt(0);
		}

		private void connectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Connect
			axSavoyHsms1.Connect = true;
			if (axSavoyHsms1.Connect)
				Trace("Port# A has been opened");
			else
				Trace("Error : Cannot open port# A");

			axSavoyHsms2.Connect = true;
			if (axSavoyHsms2.Connect)
				Trace("Port# B has been opened");
			else
				Trace("Error : Cannot open port# B");
		}

		private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Disconnect
			axSavoyHsms1.Connect = false;
			axSavoyHsms2.Connect = false;

			Trace("Port# A and B has been closed");
		}

		private void axSavoyHsms1_Received(object sender, AxSAVOYLib._DSavoyHsmsEvents_ReceivedEvent e)
		{
			// Received mesasge from port# A
			axSavoySecsII1.Msg = e.lpszMsg;

			Trace("Received from port# A");
			Trace(axSavoySecsII1.SML);

			// Forward message to port# B
			axSavoyHsms2.Send(e.lpszMsg);
		}

		private void axSavoyHsms2_Received(object sender, AxSAVOYLib._DSavoyHsmsEvents_ReceivedEvent e)
		{
			// Received mesasge from port# B
			axSavoySecsII2.Msg = e.lpszMsg;

			Trace("Received from port# B");
			Trace(axSavoySecsII2.SML);

			// Forward message to port# A
			axSavoyHsms1.Send(e.lpszMsg);
		}

		private void portASettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Port# A setting
			axSavoyHsms1.Setup("");
		}

		private void portBSettingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Port# B setting
			axSavoyHsms2.Setup("");
		}

		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
			// Get currently selected item
			if (listBox1.SelectedItem == null)
				return;

			string strFileName = listBox1.SelectedItem.ToString();

			try
			{
				// Open .sml file
				FileStream fs = File.OpenRead(strFileName + ".sml");
				if (fs == null)
					return;

				if (fs.Length <= 0)
					return;

				// Read
				byte[] buffer = new byte[fs.Length];
				fs.Read(buffer, 0, (int)fs.Length);
				string strSML = Encoding.Default.GetString(buffer);

				// Send message
				bool bPortA = (toolStripTargetPort.SelectedIndex == 0);
				AxSAVOYLib.AxSavoySecsII msg = bPortA ? axSavoySecsII1 : axSavoySecsII2;
				msg.SML = strSML;
				Send(bPortA);
			}
			catch
			{
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Savoy HSMS Logger\nver " + Application.ProductVersion + "\n\nCopyrigh(C)2009 Jazz Soft, Inc.", "About " + Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void helpToolStripButton_Click(object sender, EventArgs e)
		{
			aboutToolStripMenuItem_Click(sender, e);
		}

		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			// Enumerate message files
			DirectoryInfo di = new DirectoryInfo(".\\");
			FileInfo[] fis = di.GetFiles("*.sml");
			foreach (FileInfo fi in fis)
				listBox1.Items.Add(fi.Name.Substring(0, fi.Name.Length - 4));
		}
	}
}
