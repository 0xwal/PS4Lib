using System.Linq;
internal static class Memory
{

    internal static bool ReadMemory(ulong address, ref byte[] buffer, int? length = null)
    {

        int locLength = length ?? buffer.Length;
        MemoryStruct ms;
        ms.Command = (byte) Command.Read;
        ms.Address = address;
        ms.Length = locLength;
        byte[] structAsArray = Helper.StructToByteArray(ms);
        if (!Global.ExecCommand(structAsArray, ref buffer))
            return false;
        bool isOk = buffer[0] == Const.SUCCESS_OPERATION;
        buffer = buffer.ToList().GetRange(1, locLength).ToArray();
        return isOk;

    }

    internal static bool WriteMemory(ulong address, byte[] buffer, int length)
    {

        MemoryStruct ms;
        ms.Command = (byte) Command.Write;
        ms.Address = address;
        ms.Length = length;
        byte[] structAsArray = Helper.StructToByteArray(ms);
        var dataIn = structAsArray.Concat(buffer).ToArray();
        byte[] bufOut = new byte[1];
        if (!Global.ExecCommand(dataIn, ref bufOut))
            return false;
        return bufOut[0] == Const.SUCCESS_OPERATION;

    }
}

