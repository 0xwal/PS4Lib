internal class Process
{
    internal static bool Attach()
    {
        return Global.ExecCommandWithOutArgsWithOutReturn(Command.Attach);
    }

    internal static bool Detach()
    {
        return Global.ExecCommandWithOutArgsWithOutReturn(Command.Detach);
    }

    internal static bool Continue()
    {
        return Global.ExecCommandWithOutArgsWithOutReturn(Command.Conitnue);
    }
    internal static bool Resume()
    {
        return Global.ExecCommandWithOutArgsWithOutReturn(Command.Resume);
    }
    internal static bool Suspend()
    {
        return Global.ExecCommandWithOutArgsWithOutReturn(Command.Suspend);
    }
}