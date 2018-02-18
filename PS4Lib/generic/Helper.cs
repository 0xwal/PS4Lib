using System;
using System.Runtime.InteropServices;


internal class Helper
{
    public static byte[] StructToByteArray(object obj)
    {
        int structSize = Marshal.SizeOf(obj);

        byte[] buffer = new byte[structSize];

        IntPtr ptr = Marshal.AllocHGlobal(structSize);

        Marshal.StructureToPtr(obj, ptr, true);

        Marshal.Copy(ptr, buffer, 0, structSize);

        Marshal.FreeHGlobal(ptr);

        return buffer;
    }
}

