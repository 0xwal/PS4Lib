internal static class Connection
{
    internal static SocketClient SocketClient { get; private set; }
    private static int _portRangePossibility;

    internal static void Init(string ip, int port,  int portRange)
    {
        _portRangePossibility = portRange;
        SocketClient = new SocketClient(ip, port, 3000);

    }
    internal static bool IsConnected()
    {
        byte[] rfBytes = new byte[1];
        return Global.ExecCommandWithOutArgs(0, ref rfBytes);
    }
    internal static void Disconnect()
    {
        Global.ExecCommandWithOutArgsWithOutReturn(Command.Quit);
        SocketClient.Disconnect();
    }
    internal static bool Connect()
    {
        int range = _portRangePossibility;
        for (int i = 0; i < range; i++)
        {
            if(SocketClient.Connect())
                return true;
            SocketClient.Port++;
        }
        return false;
    }

   

}
