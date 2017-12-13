using System;

namespace AssassinEventSystem.EventArguments
{
    public class InformationEventArgs : EventArgs
    {
        public string Message { get; set; }

        public InformationEventArgs(string information)
        {
            Message = information;
        }
    }
}