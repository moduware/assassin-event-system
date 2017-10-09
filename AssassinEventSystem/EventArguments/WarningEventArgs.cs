using System;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.EventArguments
{
    public class WarningEventArgs : EventArgs
    {
        public Warning Warning { get; set; }

        public WarningEventArgs(Warning warning)
        {
            Warning = warning;
        }
    }
}