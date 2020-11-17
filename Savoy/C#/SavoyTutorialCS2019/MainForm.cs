using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavoyTutorialCS2019
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// Setup
			hsms.LoadIniFile();
			if (hsms.Setup(""))
			{
				// If OK button was pressed, establish connection
				hsms.Connect = true;
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			// Send S1F13
			outmsg.SML = "s1f13w{}";
			hsms.Send(outmsg.Msg);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			// Send S2F41 PP-Select
			outmsg.SML = "s2f41w{<a'PP-SELECT'>{{<a'PPID'><a'" + textBox1.Text + "'>}}}";
			hsms.Send(outmsg.Msg);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			// Send S2F41 Start
			outmsg.SML = "s2f41w{<A'START'>{{}}}";
			hsms.Send(outmsg.Msg);
		}

		private void hsms_Connected(object sender, AxSAVOYLib._DSavoyHsmsEvents_ConnectedEvent e)
		{
			// Connected
			// Send select request
			outmsg.SML = "Select.req";
			hsms.Send(outmsg.Msg);
		}

		private void hsms_Received(object sender, AxSAVOYLib._DSavoyHsmsEvents_ReceivedEvent e)
		{
			inmsg.Msg = e.lpszMsg;
			switch (inmsg.SType)
			{
				case 0:
					// Data message
					if (inmsg.Wbit && (inmsg.Function % 2) != 0)
					{
						// Need to reply something...
						outmsg.SML = "<b 0>";
						outmsg.Reply(e.lpszMsg);
						hsms.Send(outmsg.Msg);
					}
					break;
				case 1:
					// Select request
					outmsg.SML = "Select.rsp";
					outmsg.Reply(e.lpszMsg);
					hsms.Send(outmsg.Msg);
					break;
			}
		}
	}
}
