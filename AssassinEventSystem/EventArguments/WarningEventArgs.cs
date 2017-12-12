using System;

namespace AssassinEventSystem.EventArguments
{
    public class WarningEventArgs : EventArgs
    {
        //public Warning Warning { get; set; }
        public string Message { get; set; }

        public WarningEventArgs(string warning)
        {
            Message = warning;
        }
    }
}