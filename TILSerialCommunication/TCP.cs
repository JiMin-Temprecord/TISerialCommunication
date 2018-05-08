using System;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;

namespace TILCommsNetwork
{
	private TcpClient TCP; 
	private NetworkStream stream;
	private string IPaddress; 
	private int Port;
	
	
	public class TCP(String ipaddress = "192.168.1.103", int port = 4001)
	{	
		IPaddress = ipaddress;
		Port = port;
	}
	
	public string IPaddress
	{
		get{return IPaddress;}
		set{IPaddress = value;}
	}
	
	public int Port
	{
		get{return Port;}
		set{Port = value;}
	}
	
	private bool connect()
	{
		try
		{
			TCP.connect(IPaddress,Port);
			return true;
		}
		catch(System.Net.Sockets.SocketException) 
		{
			return false;
		}
	}
	
	private bool getStream()
	{
		try
		{
			stream = TCP.GetStream();
			return true;
		}
		catch (System.ObjectDisposedException)
		{
			return false;
		}
		
			
	}
	
	
}