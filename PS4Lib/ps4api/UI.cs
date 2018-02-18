using System;
using System.Linq;
using System.Text;

internal class UI
{
    internal static void Notify(int nType, string text)
    {//as fast as run : )
        byte[] command = { (byte)Command.Notify };
        byte[] notifyType = BitConverter.GetBytes(nType);
        byte[] txt = Encoding.UTF8.GetBytes(text);
        byte[] allBytes = command.Concat(notifyType).Concat(txt).ToArray();

        Global.ExecCommandWithArgs(allBytes);

    }
}