using System;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Diagnostics;

public class Projector
{

    private String ip;

	public Projector(String ip)
	{
        this.ip = ip;
	}

    internal void turnOn()
    {
        sendMessage("PWR ON");
    }

    internal void turnOff()
    {
        sendMessage("PWR OFF");
    }

    internal void sourceSearch()
    {
        sendMessage("KEY 67");
    }

    private String sendMessage(String message)
    {
        TcpClient socket = new TcpClient(this.ip, 3629);
        NetworkStream client = socket.GetStream();
        byte[] startMessage = { 0x45, 0x53, 0x43, 0x2f, 0x56, 0x50, 0x2e, 0x6e, 0x65, 0x74, 0x10, 0x03, 0x00, 0x00, 0x00, 0x00 };
        client.Write(startMessage, 0, startMessage.Length);
        byte[] data = new byte[256];
        Int32 bytes = client.Read(data, 0, data.Length);
        String responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
        byte[] userMessage = new byte[message.Length+1];
        Buffer.BlockCopy(System.Text.Encoding.ASCII.GetBytes(message), 0, userMessage, 0, message.Length);
        userMessage[userMessage.Length-1] = 0x0d;
        client.Write(userMessage, 0, userMessage.Length);

        return responseData;
    }

}
