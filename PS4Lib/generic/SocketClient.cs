using System.Net;
using System.Net.Sockets;


internal class SocketClient
{
    private readonly Socket _socket;
    private static string _ip;
    private int _port;

    internal SocketClient(string ip, int port, int timeOut = 0)
    {
        _ip = ip;
        _port = port;
        var x_ip = IPAddress.Parse(ip);
        _socket = new Socket(x_ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
        
        if (timeOut != 0)
        {
            _socket.ReceiveTimeout = timeOut;
            _socket.SendTimeout = timeOut;
        }
    }

    internal bool Connect()
    {
        try
        {
            if (!_socket.Connected)
            _socket.Connect(_ip, _port);
            return _socket.Connected;
        }
        catch
        {
            return false;
        }
    }
    internal void Disconnect()
    {
        try
        {
                _socket.Disconnect(true);
        }
        catch
        {
            // ignored
        }
    }

    internal int Send(byte[] buffer, int length = -1)
    {
        try
        {
            return _socket.Send(buffer, length == -1 ? buffer.Length : length, 0);
        }
        catch
        {
            return -1;
        }
    }

    internal int Receive(byte[] buffer, int length = -1)
    {
        try
        {
            return _socket.Receive(buffer, length == -1 ? buffer.Length : length, 0);
        }
        catch
        {
            return -1;
        }
    }

    internal int Port {
        get { return _port; } set{_port = value;} }
}

