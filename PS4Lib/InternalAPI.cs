using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//this is stage 2
//This class will be the interface between client interface and the app
//to make the main class updatable and we don't want to demage any public lib functions in future. 
internal static class API
{
    private const int PORT = 9090;
    private const int PORT_RANGE_POSSIBILITY = 3;
    private static void Init(string ip, int port)
    {
        Connection.Init(ip, port, PORT_RANGE_POSSIBILITY);
    }

    internal static bool Connect(string ip)
    {
        if (IsConnected())
            return true;
        Init(ip, PORT);
        return Connection.Connect();
    }
    internal static bool IsConnected()
    {
        return Connection.IsConnected();
    }

    internal static void Disconnect()
    {
        Connection.Disconnect();
    }
    internal static bool Attach()
    {
        return Process.Attach();
    }

    internal static bool Detach()
    {
        return Process.Detach();
    }
    internal static bool Continue()
    {
        return Process.Continue();
    }
    internal static bool Suspend()
    {
        return Process.Suspend();
    }
    internal static bool Resume()
    {
        return Process.Resume();
    }
    internal static  bool ReadMemory(ulong address, ref byte[] buffer)
    {
        return Memory.ReadMemory(address, ref buffer);
    }
    internal static byte[] GetBytes(ulong address, int length)
    {
        byte[] refBytes = new byte[length];
        ReadMemory(address, ref refBytes);
        return refBytes;
    }
    internal static bool WriteMemory(ulong address, byte[] buffer, int length)
    {
        return Memory.WriteMemory(address, buffer, length);
    }

    internal static void Notify(int nType, string text)
    {
        UI.Notify(nType, text);
    }
}

