internal struct Const
{
    public const byte
        SUCCESS_OPERATION = 00;
}

internal enum Command : byte
{
    Attach = (byte)'a',
    Read = (byte)'r',
    Write = (byte)'w',
    Conitnue = (byte)'c',
    Detach = (byte)'d',
    Notify = (byte)'n',
    Suspend = (byte)'s',
    Resume = (byte)'u',
    Quit = (byte)'q'
}