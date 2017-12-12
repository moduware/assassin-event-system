using System;

namespace AssassinEventSystem.EventArguments
{
    public class ErrorEventArgs : EventArgs
    {
        //public Error Error { get; set; }
        public string Message { get; set; }

        public ErrorEventArgs(string error)
        {
            Message = error;
        }
    }
}