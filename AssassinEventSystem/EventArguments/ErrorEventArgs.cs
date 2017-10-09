using System;
using AssassinEventSystem.Infrastructure;

namespace AssassinEventSystem.EventArguments
{
    public class ErrorEventArgs : EventArgs
    {
        public Error Error { get; set; }

        public ErrorEventArgs(Error error)
        {
            Error = error;
        }
    }
}