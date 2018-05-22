using System;

namespace AssassinEventSystem.EventArguments
{
    public class WarningEventArgs : EventArgs
    {
        public string Message { get; set; }

        public WarningEventArgs(string warning)
        {
            Message = warning;
        }
    }
}