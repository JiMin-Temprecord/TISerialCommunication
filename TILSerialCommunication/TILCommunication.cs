using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TILCommsNetwork
{
	TCP tcp = new TCP;
	
	public void sendbutton_Click(object sender, EventArgs e)
	{
		if(tcp.Active == false){
			tcp.open();
		}
	}
} 