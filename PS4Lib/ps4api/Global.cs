internal static class Global
{
    internal static bool ExecCommand(byte[] input, ref byte[] output)
    {
        if (Connection.SocketClient == null)
            return false;
        byte[] locInput = input;
        if (Connection.SocketClient.Send(locInput, locInput.Length) < 1)
            return false;

        byte[] returnBytes = new byte[output.Length + 1];

        if (Connection.SocketClient.Receive(returnBytes) < 1)
            return false;
        output = returnBytes;
        return true;

    }

    internal static bool ExecCommandWithArgs(byte[] input)
    {
        byte[] refBytes = new byte[0];
        return ExecCommand(input, ref refBytes);
    }
    internal static bool ExecCommandWithOutArgs(Command command, ref byte[] output)
    {
        return ExecCommand(new byte[] {(byte)command}, ref output);
    }
    internal static bool ExecCommandWithOutArgsWithOutReturn(Command command)
    {
        byte[] output = new byte[0];
        if (!ExecCommand(new byte[] {(byte)command}, ref output))
            return false;
        return output[0] == Const.SUCCESS_OPERATION;

    }
}

