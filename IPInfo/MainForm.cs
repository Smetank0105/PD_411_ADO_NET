using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace IPInfo
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		void Info()
		{
			try
			{
				IPAddress address = IPAddress.Parse(textBoxIP.Text);
				IPAddress mask = IPAddress.Parse(textBoxMask.Text);

				uint numAddress = BitConverter.ToUInt32(address.GetAddressBytes(), 0);
				uint numMask = BitConverter.ToUInt32(mask.GetAddressBytes(), 0);

				int cidr = 0;
				uint temp = numMask;
				while (temp > 0)
				{
					cidr += (int)(temp & 1);
					temp >>= 1;
				}

				uint networkAddress = numAddress & numMask;
				IPAddress network = new IPAddress(networkAddress);
				textBoxNetwork.Text = network.ToString();

				uint broadcastAddress = networkAddress | (~numMask);
				IPAddress broadcast = new IPAddress(broadcastAddress);
				textBoxBroadcast.Text = broadcast.ToString();

				long addressCount = 1L << (32 - cidr);
				textBoxIPcount.Text = addressCount.ToString();

				long hostCount;
				if (cidr >= 31)
				{
					hostCount = (cidr == 31) ? 2 : 1;
				}
				else 
					hostCount = addressCount - 2;
				textBoxHostcount.Text = hostCount.ToString();
			}
			catch (Exception){}
		}

		private void button_Click(object sender, EventArgs e)
		{
			Info();
		}
	}
}
